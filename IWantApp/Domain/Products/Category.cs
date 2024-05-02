using System;

namespace IWantApp.Domain.Products {
    public class Category : Entity {
        public string Name { get; set; }
        public bool Active { get; internal set; } = true;
    }
}
