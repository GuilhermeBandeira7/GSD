using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GunShooterDetector.Models.ModelCalibracao
{
    public class CalibrationChanel1ResponseModel
    {
        public string HEADER = "ch1CalSuccess";
        string SN = string.Empty;
        public int GCL1; //GANHO 1 A 100
        public int VCL1 = 65; //TENSÃO 0 A 3.300
        public int TCL1 = 1000; //TEMPO MEDIÇÃO 0 A 10.000 MS
        public int REQ1 = 1000; //ARMAZENA DEGRAUS EM OHMS

        public override string ToString()
        {
            String message = "\n VALORES ATUALIZADOS:  " + "\n" + "\n Ganho Canal 1: " + GCL1.ToString() + "\n"
                + "\n Tensão de Calibração Canal 1 : " + VCL1.ToString() + "\n" + "\n Tempo de Medição de Calibração Canal 1 : "
                + TCL1.ToString() + "\n" + "\n Resistência Equivalente Canal 1 : " + REQ1.ToString();
            return message;
        }
    }
}
