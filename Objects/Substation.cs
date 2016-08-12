using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NERC.Objects
{
    class Substation
    {
        public string Name { get; set; }
        public List<Device> Devices;

        /// <summary>
        /// Creates a new Substation object.
        /// </summary>
        /// <param name="name">Name of the substation.</param>
        /// <param name="devices">List of Device objects in that substation</param>
        Substation(string name = "", List<Device> devices = null)
        {
            Name = name;
            Devices = devices;
        }
    }
}
