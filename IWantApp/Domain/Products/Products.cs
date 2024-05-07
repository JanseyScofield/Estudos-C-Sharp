using Flunt.Validations;
using System;
using System.Xml.Linq;

namespace IWantApp.Domain.Products {
    public class Products : Entity {
        public string Name { get; set; }
        public Guid CategoryId { get; set; }
        public Category Category { get; set; }
        public string Description { get; set; }
        public bool HasStock{ get; set; }
        public bool Active { get; set; } = true;

        public Products(string name, Category category, string description, bool hasStock, string createdBy) { 
            Name = name;
            Category = category;
            Description = description;
            HasStock = hasStock;
            CreatedBy = createdBy;

            EditedBy = createdBy;
            CreatedOn = DateTime.Now;
            EditedOn = DateTime.Now;

            Validate();
        }
        public void Validate() {
            var contract = new Contract<Products>()
                .IsNotNullOrEmpty(Name, "Name", "Nome é obrigatório.")
                .IsGreaterOrEqualsThan(Name, 3, "Name")
                .IsGreaterOrEqualsThan(Description, 3, "Descrição deve ter mais de 3 caracteres");
            AddNotifications(contract);
        }
    }



}
