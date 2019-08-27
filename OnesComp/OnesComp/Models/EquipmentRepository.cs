using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnesComp.Models
{
    public class EquipmentRepository : IEquipmentRepository
    {
        private readonly AppDbContext _appDbContext;

        public EquipmentRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Equipment> GetAllEquipments()
        {
            return _appDbContext.Equipments;
        }

        public Equipment GetEquipmentById(int equipmentId)
        {
            return _appDbContext.Equipments.FirstOrDefault(p => p.Id == equipmentId);
        }
    }
}
