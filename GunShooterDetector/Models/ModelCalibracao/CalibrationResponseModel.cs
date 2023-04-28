using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GunShooterDetector.Models.ModelCalibracao
{
    public class CalibrationResponseModel
    {
        public string HEADER = string.Empty;
        public string SN = string.Empty;
        public int VOF1 = 1; //tensão de offset canal 1
        public int TOF1 = 1; //tempo de medição de offset canal 1
        public int VOF2 = 1; //tensão de offset canal 2
        public int TOF2 = 1; //tempo de medição de offset canal 2

        public override string ToString()
        {
            String message = "VALORES ATUALIZADOS:  " + "\n" + "Numero Serial: " + SN + "\n" + "\n Tensão Offset Canal 1: " + VOF1.ToString() + "\n"
                + "\n Tempo Medição offset canal 1: "+ TOF1.ToString() + "\n" + "\n Tensão offset canal 2: "
                + VOF2.ToString() + "\n" + "\n Tempo medição de offset canal 2: "+ TOF2.ToString();
            return message;
        }
    }
}
