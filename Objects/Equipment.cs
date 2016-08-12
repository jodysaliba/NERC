using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NERC.Objects
{
    class Equipment
    {
        public string Manufacturer { get; set; }
        public string Type { get; set; }
        public bool InService { get; set; }

        /// <summary>
        /// Creates new Equipment object to be linked to a Device.
        /// </summary>
        /// <param name="manufacturer">Manufacturer of the piece of equipment.</param>
        /// <param name="type">Type/Style of the equipment.</param>
        /// <param name="inService">Is the equipment in service?</param>
        public Equipment(string manufacturer = "", string type = "", bool inService = true)
        {
            Manufacturer = manufacturer;
            Type = type;
            InService = inService;
        }
    }
}
