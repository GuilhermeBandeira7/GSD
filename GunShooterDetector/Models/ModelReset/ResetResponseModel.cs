using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GunShooterDetector.Models.ModelReset
{
    public class ResetResponseModel
    {
        public string HEADER { get; set; } = "resetSuccess";
        public int MODE { get; set; } = 0;
        public int INFE { get; set; } = 50;
        public int MRL1 { get; set; }
        public int TRL1 { get; set; } = 500;
        public int MRL2 { get; set; } = 2;
        public int TRL2 { get; set; } = 500;
        public int MLED { get; set; } = 1;
        public int GCH1 { get; set; } = 10;
        public int GCH2 { get; set; } = 10;
        public int GSPK { get; set; } = 10;
    }
}
