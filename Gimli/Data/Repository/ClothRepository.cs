using Gimli.Data.Entities;
using Gimli.Data.Entities.Enums;
using Gimli.Data.Repository.Base;
using System.Collections.Generic;
using System.Linq;

namespace Gimli.Data.Repository
{
    public class ClothRepository : Repository<Cloth>, IClothRepository
    {
        public ClothRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            
        }
        public IQueryable<Cloth> GetHeadPieces()
        {
            var headPieces = GetAll().Where(p => p.Type == ClothType.Head);
            return headPieces;
        }
    }
}
