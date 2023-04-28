using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GunShooterDetector.Models.ModelCalibracao
{
    public class CalibrationRequestModel
    {
        public string HEADER = "offsetCal";
        public string SN = string.Empty;
        public int TOF1 = 5000;
        public int TOF2 = 5000;
    }
}
