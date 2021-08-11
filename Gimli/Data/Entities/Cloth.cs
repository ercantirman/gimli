using Gimli.Data.Entities.Base;
using Gimli.Data.Entities.Enums;

namespace Gimli.Data.Entities
{
    public class Cloth : Entity
    {
        public string Name { get; set; }

        public ClothType Type { get; set; }

        //We have forgotten the ImageUrl field before
        //Don't forget to add a new migration and update the database after modifying this entity like below

        //public string ImageUrl { get; set; }
    }
}
