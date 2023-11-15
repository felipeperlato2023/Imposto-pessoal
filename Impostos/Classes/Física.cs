using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Impostos.Classes
{
    class Física : Pessoa
    {
        public double Gastosaude { get; set; }  
        public Física(string nome, double ranual, double gastosaude) : base(nome,ranual)
        {
            Gastosaude = gastosaude;
        }

        public override double Imposto()
        {
            if (Ranual < 200000 && Gastosaude > 0)
            {

                double ranual = (Ranual * 15 / 100) + (Gastosaude / 2);
                return ranual;
            }
            else if (Ranual > 200000 && Gastosaude > 0)
            {
                double ranual = (Ranual * 25 / 100) + (Gastosaude / 2);
                return ranual;
            }
            else if (Ranual < 200000 && Gastosaude == 0)
            {
                double ranual = (Ranual * 25 / 100);
                return ranual;
            }
            return Ranual;
        }
    }
}
