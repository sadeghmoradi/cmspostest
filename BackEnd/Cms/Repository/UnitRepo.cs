using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using Entity.Model.Units;
using EntityDB;
using IRepository;

namespace Repository
{
    public class UnitRepo : RepositoryBase<Unit>, IRepositoryUnit
    {
        private readonly RepositoryContext repositoryContext;

        public UnitRepo(RepositoryContext repositoryContext):base(repositoryContext)
        {
            this.repositoryContext = repositoryContext;
        }

        public IEnumerable<UnitDto> GetunitDto()
        {

            List<UnitDto> unitDto = new List<UnitDto>();
            UnitDto un;
            //var ss = repositoryContext.Units
            //           .FirstOrDefault<Unit>();
            //repositoryContext.Entry(ss).Collection(s => s.unitType).Load();
            //UnitDto un = new UnitDto(ss);
            //unitDto.Add(un);

            var unitDt =repositoryContext.Units.Include(res => res.UnitTypes).ToList();
            foreach (var item in unitDt)
            {
                un = new UnitDto(item);
                unitDto.Add(un);
            }

            return unitDto;
        }
    }
}
