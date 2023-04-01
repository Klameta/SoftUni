namespace Boardgames.DataProcessor
{
    using System.ComponentModel.DataAnnotations;
    using System.Text;
    using System.Xml.Serialization;
    using Boardgames.Data;
    using Boardgames.Data.Models;
    using Boardgames.Data.Models.Enums;
    using Boardgames.DataProcessor.ImportDto;
    using Newtonsoft.Json;

    public class Deserializer
    {
        private const string ErrorMessage = "Invalid data!";

        private const string SuccessfullyImportedCreator
            = "Successfully imported creator – {0} {1} with {2} boardgames.";

        private const string SuccessfullyImportedSeller
            = "Successfully imported seller - {0} with {1} boardgames.";
        private static T Deserialize<T>(string inputXml, string rootName)
        {
            XmlRootAttribute root = new XmlRootAttribute(rootName);
            XmlSerializer serializer = new XmlSerializer(typeof(T), root);

            using StringReader reader = new StringReader(inputXml);

            T dtos = (T)serializer.Deserialize(reader);
            return dtos;
        }
        public static string ImportCreators(BoardgamesContext context, string xmlString)
        {
            var creatorsDTOs = Deserialize<ImportCreatorDTO[]>(xmlString, "Creators");
            StringBuilder output = new StringBuilder();
            var validCreators = new List<Creator>();

            foreach (var creatorDTO in creatorsDTOs)
            {
                if (!IsValid(creatorDTO))
                {
                    output.AppendLine(ErrorMessage);
                    continue;
                }

                var validBoardgames = new List<Boardgame>();
                foreach (var boardgameDTO in creatorDTO.Boardgames)
                {
                    if (!IsValid(boardgameDTO))
                    {
                        output.AppendLine(ErrorMessage);
                        continue;
                    }

                    Boardgame boardgame = new Boardgame()
                    {
                        Name = boardgameDTO.Name,
                        Rating = boardgameDTO.Rating,
                        YearPublished = boardgameDTO.YearPublished,
                        CategoryType = (CategoryType)boardgameDTO.CategoryType,
                        Mechanics = boardgameDTO.Mechanics
                    };
                    validBoardgames.Add(boardgame);
                }

                Creator creator = new Creator()
                {
                    FirstName = creatorDTO.FirstName,
                    LastName = creatorDTO.LastName,
                    Boardgames = validBoardgames
                };
                validCreators.Add(creator);

                output.AppendLine(string.Format(SuccessfullyImportedCreator, creator.FirstName, creator.LastName, validBoardgames.Count));
            }

            context.Creators.AddRange(validCreators);
            context.SaveChanges();

            return output.ToString().TrimEnd();
        }

        public static string ImportSellers(BoardgamesContext context, string jsonString)
        {
            var output = new StringBuilder();

            var sellersDTOs = JsonConvert.DeserializeObject<ImportSellerDTO[]>(jsonString);
            var validSellers = new HashSet<Seller>();
            var existingBoardgames = context.Boardgames
                .Select(t => t.Id)
                .ToArray();

            foreach (var sellerDTO in sellersDTOs)
            {
                if (!IsValid(sellerDTO))
                {
                    output.AppendLine(ErrorMessage);
                    continue;
                };

                Seller seller = new Seller()
                {
                    Name = sellerDTO.Name,
                    Address = sellerDTO.Address,
                    Country = sellerDTO.Country,
                    Website = sellerDTO.Website
                };
                foreach (var boardgameId in sellerDTO.BoardgamesIds.Distinct())
                {
                    if (!existingBoardgames.Contains(boardgameId))
                    {
                        output.AppendLine(ErrorMessage);
                        continue;
                    }

                    BoardgameSeller boardgameSeller = new BoardgameSeller()
                    {
                        Seller = seller,
                        BoardgameId = boardgameId,
                    };
                    seller.BoardgamesSellers.Add(boardgameSeller);
                }
                validSellers.Add(seller);
                output
                    .AppendLine(string.Format(SuccessfullyImportedSeller, seller.Name, seller.BoardgamesSellers.Count()));
            }
            context.Sellers.AddRange(validSellers);
            context.SaveChanges();

            return output.ToString().TrimEnd();
        }

        private static bool IsValid(object dto)
        {
            var validationContext = new ValidationContext(dto);
            var validationResult = new List<ValidationResult>();

            return Validator.TryValidateObject(dto, validationContext, validationResult, true);
        }
    }
}
