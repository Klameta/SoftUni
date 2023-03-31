using CarDealer.Data;
using CarDealer.Models;
using Newtonsoft.Json;
using System.IO;

namespace CarDealer
{
    public class StartUp
    {
        public static void Main()
        {
            var context = new CarDealerContext();

            Console.WriteLine(GetSalesWithAppliedDiscount(context));
            /*            context.Database.EnsureDeleted();
                        context.Database.EnsureCreated();

                        ImportSuppliers(context, File.ReadAllText(@"../../../Datasets/suppliers.json"));
                        ImportParts(context, File.ReadAllText(@"../../../Datasets/parts.json"));
                        ImportCars(context, File.ReadAllText(@"../../../Datasets/cars.json"));
                        ImportCustomers(context, File.ReadAllText(@"../../../Datasets/customers.json"));

                        string inputJson = File.ReadAllText(@"../../../Datasets/sales.json");
                        Console.WriteLine(ImportSales(context, inputJson));
            */
        }

        public static string ImportSuppliers(CarDealerContext context, string inputJson)
        {
            var suppliers = JsonConvert.DeserializeObject<List<Supplier>>(inputJson);
            context.AddRange(suppliers);
            context.SaveChanges();

            return $"Successfully imported {suppliers.Count}.";
        }
        public static string ImportParts(CarDealerContext context, string inputJson)
        {
            var parts = JsonConvert.DeserializeObject<List<Part>>(inputJson)
                .Where(p => context.Suppliers.FirstOrDefault(s => s.Id == p.SupplierId) != null)
                .ToList();
            context.Parts.AddRange(parts);
            context.SaveChanges();

            return $"Successfully imported {parts.Count}.";
        }
       /* public static string ImportCars(CarDealerContext context, string inputJson)
        {
            var carsAndPartsDTO = JsonConvert.DeserializeObject<List<CarDTO>>(inputJson);

            List<PartCar> parts = new List<PartCar>();
            List<Car> cars = new List<Car>();

            foreach (var dto in carsAndPartsDTO)
            {
                Car car = new Car()
                {
                    Make = dto.Make,
                    Model = dto.Model,
                    TravelledDistance = dto.TravelledDistance
                };
                cars.Add(car);

                foreach (var part in dto.PartsId.Distinct())
                {
                    PartCar partCar = new PartCar()
                    {
                        Car = car,
                        PartId = part,
                    };
                    parts.Add(partCar);
                }
            }

            context.Cars.AddRange(cars);
            context.PartsCars.AddRange(parts);
            context.SaveChanges();
            return $"Successfully imported {cars.Count}.";

        }
       */ public static string ImportCustomers(CarDealerContext context, string inputJson)
        {
            var customers = JsonConvert.DeserializeObject<List<Customer>>(inputJson);

            context.Customers.AddRange(customers);
            context.SaveChanges();

            return $"Successfully imported {customers.Count}.";
        }
        public static string ImportSales(CarDealerContext context, string inputJson)
        {
            var sales = JsonConvert.DeserializeObject<List<Sale>>(inputJson);

            context.Sales.AddRange(sales);
            context.SaveChanges();

            return $"Successfully imported {sales.Count}.";
        }
        public static string GetOrderedCustomers(CarDealerContext context)
        {
            var customers = context.Customers
                .OrderBy(c => c.BirthDate)
                .ThenBy(c => c.IsYoungDriver)
                .Select(c => new
                {
                    Name = c.Name,
                    BirthDate = c.BirthDate.ToString("dd/MM/yyyy"),
                    IsYoungDriver = c.IsYoungDriver
                });

            string jsonCustomer = JsonConvert.SerializeObject(customers, Formatting.Indented);
            return jsonCustomer;
        }
        /* public static string GetCarsFromMakeToyota(CarDealerContext context)
         {
             var cars = context.Cars
                 .Where(c => c.Make == "Toyota")
                 .OrderBy(c => c.Model)
                 .ThenByDescending(c => c.TravelledDistance)
                 .Select(c => new
                 {
                     Id = c.Id,
                     Make = c.Make,
                     Model = c.Model,
                     TraveledDistance = c.TravelledDistance
                 }).ToList();

             string jsonCars = JsonConvert.SerializeObject(cars, Formatting.Indented);

             return jsonCars;
         }*/
        public static string GetLocalSuppliers(CarDealerContext context)
        {
            var supplies = context.Suppliers
                .Where(s => !s.IsImporter)
                .Select(s => new
                {
                    Id = s.Id,
                    Name = s.Name,
                    PartsCount = s.Parts.Count
                })
                .ToList();

            var jsonSupplies = JsonConvert.SerializeObject(supplies, Formatting.Indented);
            return jsonSupplies;
        }
        /* public static string GetCarsWithTheirListOfParts(CarDealerContext context)
         {
             var cars = context.Cars
                 .Select(c => new
                 {
                     car = new
                     {
                         Make = c.Make,
                         Model = c.Model,
                         TraveledDistance = c.TraveledDistance,
                     },
                     parts = c.PartsCars.Select(s => new
                     {
                         Name = s.Part.Name,
                         Price = $"{s.Part.Price:F2}"
                     })

                 })
                 .ToList();

             return JsonConvert.SerializeObject(cars, Formatting.Indented);
         }
        */
        public static string GetTotalSalesByCustomer(CarDealerContext context)
        {
            var customers = context.Customers
                .Where(c => c.Sales.Any())
                .Select(c => new
                {
                    fullName = c.Name,
                    boughtCars = c.Sales.Count(),
                    salePrices = c.Sales.SelectMany(x => x.Car.PartsCars.Select(x => x.Part.Price))
                }).ToArray();



            var totalSalesByCustomer = customers.Select(t => new
            {
                t.fullName,
                t.boughtCars,
                spentMoney = t.salePrices.Sum()
            })
            .OrderByDescending(t => t.spentMoney)
            .ThenByDescending(t => t.boughtCars)
            .ToArray();

            return JsonConvert.SerializeObject(totalSalesByCustomer, Formatting.Indented);
        }
        public static string GetSalesWithAppliedDiscount(CarDealerContext context)
        {
            var salesWithDiscount = context.Sales
                 .Take(10)
                 .Select(s => new
                 {
                     car = new
                     {
                         s.Car.Make,
                         s.Car.Model,
                         s.Car.TraveledDistance
                     },
                     customerName = s.Customer.Name,
                     discount = $"{s.Discount:f2}",
                     price = $"{s.Car.PartsCars.Sum(p => p.Part.Price):f2}",
                     priceWithDiscount = $"{s.Car.PartsCars.Sum(p => p.Part.Price) * (1 - s.Discount / 100):f2}"
                 })
                 .ToArray();

            return JsonConvert.SerializeObject(salesWithDiscount, Formatting.Indented);
        }
    }
}