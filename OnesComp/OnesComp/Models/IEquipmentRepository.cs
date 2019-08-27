using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnesComp.Models
{
    public interface IEquipmentRepository
    {
        IEnumerable<Equipment> GetAllEquipments();
        Equipment GetEquipmentById(int equipmentId);
    }
}
