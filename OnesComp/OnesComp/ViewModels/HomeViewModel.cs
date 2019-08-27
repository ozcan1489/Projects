using OnesComp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnesComp.ViewModels
{
    public class HomeViewModel
    {
        public string Title { get; set; }
        public List<Equipment> Equipments { get; set; }
    }
}
