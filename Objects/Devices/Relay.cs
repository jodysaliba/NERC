using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NERC.Objects;

namespace NERC.Objects.Devices
{
    class Relay : Equipment
    {
        public string SerialNumber { get; set; }
        public int Status { get; set; }
        public List<Test> Tests { get; set; }

        Relay()
        {

        }
    }
}
