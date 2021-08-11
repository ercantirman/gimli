using Gimli.Data.Entities.Base;
using Gimli.Data.Entities.Enums;

namespace Gimli.Data.Entities
{
    public class Cloth : Entity
    {
        public string Name { get; set; }

        public ClothType Type { get; set; }
    }
}
