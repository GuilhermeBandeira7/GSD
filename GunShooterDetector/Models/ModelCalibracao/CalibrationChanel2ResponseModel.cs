using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GunShooterDetector.Models.ModelCalibracao
{
    public class CalibrationChanel2ResponseModel
    {
        public string HEADER = "ch2CalSuccess";
        public string SN = string.Empty;
        public int GCL2 = 10; //GANHO 1 A 100
        public int VCL2 = 65; //TENSÃO 0 A 3.300
        public int TCL2 = 1000; //TEMPO MEDIÇÃO 0 A 10.000 MS
        public int REQ2 = 1000; //ARMAZENA DEGRAUS EM OHMS

        public override string ToString()
        {
            String message = " \n VALORES ATUALIZADOS:  "+ "\n" + "\n Ganho Canal 2: " + GCL2.ToString() + "\n"
                + "\n Tensão de Calibração Canal 2 : " + VCL2.ToString() + "\n" + "\n Tempo de Medição de Calibração Canal 2 : "
                + TCL2.ToString() + "\n" + "\n Resistência Equivalente Canal 2 : " + REQ2.ToString();
            return message;
        }
    }
}
