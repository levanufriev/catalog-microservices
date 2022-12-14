using System;
using Play.Common;

namespace Play.Catalog.Service.Models
{

    public class Item : IEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public DateTimeOffset CreationDate { get; set; }
    }
}