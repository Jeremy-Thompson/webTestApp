using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webTestApp.Models
{
    public class SensorModule
    {
        private int _id { get; set; }
        private int _serial_number { get; set; }
        private int _port_count { get; set; }
        private int[] _input_ports { get; set; }

        #region Class Methods

        public bool addSensorToPort(int sensorID, int portNumber)
        {
            return true;
        }

        #endregion

    }
}