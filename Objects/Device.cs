using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NERC.Objects
{
    class Device
    {
        public string Designation { get; set; }
        public List<Equipment> EquipmentList { get; set; }
        public bool Nerc { get; set; }
        public bool InService { get; set; }

        /// <summary>
        /// Creates a new Device object that will be in a Substation
        /// </summary>
        /// <param name="designation">Device designation (e.g. 61T87, 6111-1, etc.)</param>
        /// <param name="equipmentList">List of Equipment objects linked to the device (relays, CTs, PTs, CCVTs)</param>
        /// <param name="nerc">Is the device in the NERC program?</param>
        /// <param name="inService">Is the device still in service?</param>
        Device(string designation = "", List<Equipment> equipmentList = null, bool nerc = true, bool inService = true)
        {
            Designation = designation;
            EquipmentList = equipmentList;
            Nerc = nerc;
            InService = inService;
        }
    }
}
