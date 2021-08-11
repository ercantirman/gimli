using Gimli.Data.Entities;
using Gimli.Data.Repository.Base;
using System.Linq;

namespace Gimli.Data.Repository
{
    public interface IClothRepository : IRepository<Cloth>
    {
        IQueryable<Cloth> GetHeadPieces();
    }
}
