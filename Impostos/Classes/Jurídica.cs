using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Impostos.Classes
{
    internal class Jurídica : Pessoa
    {
        public int Nfuncionarios { get; set; }


        public Jurídica(string nome, double ranual, int nfuncionarios) : base(nome, ranual)
        {
            Nfuncionarios = nfuncionarios;
        }
        public override double Imposto()
        {
            if(Nfuncionarios > 10)
            {
                Ranual = Ranual * 14 / 100;
            }
            else
                Ranual = Ranual * 16 / 100;
            return Ranual;
        }
    }
}
