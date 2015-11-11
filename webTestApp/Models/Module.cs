using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webTestApp.Models
{
    public class Module
    {
        public Module(int module_id, int user_id, string sensor_type)
        {
            _module_id = module_id;
            _user_id = user_id;
            _sensor_type = sensor_type;

        }
        private int _module_id { get; set; }
        private int _user_id { get; set; }
        private int _port_count { get; set; }
        private string _sensor_type { get; set; }
        private int[] _input_ports { get; set; }

        #region Class Methods

        public bool addSensorToPort(int sensorID, int portNumber)
        {
            return true;
        }

        #endregion

    }
}