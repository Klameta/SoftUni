using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ProductShop.DTOs.Export
{
    public class ExportUsersWProducts
    {
        [XmlElement("count")]
        public int Count { get; set; }
        [XmlArray("users")]
        public UserInfo[] UsersWProducts { get; set; }
    }

    [XmlType("User")]
    public class UserInfo
    {
        [XmlElement("firstName")]
        public string FirstName { get; set; }
        [XmlElement("lastName")]
        public string LastName { get; set; }
        [XmlElement("age")]
        public int? Age { get; set; }
        public SoldProductsDTO SoldProducts { get; set; }
    }

    [XmlType("SoldProducts")]
    public class SoldProductsDTO
    {
        [XmlElement("count")]
        public int Count { get; set; }
        [XmlArray("products")]
        public UsersSoldProductDTO[] Products { get; set; }
    }

    [XmlType("Product")]
    public class UsersSoldProductDTO
    {
        [XmlElement("name")]
        public string Name { get; set; }
        [XmlElement("price")]
        public decimal Price { get; set; }
    }
}
