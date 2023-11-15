using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Impostos.Classes
{
    abstract class Pessoa
    {
        public string Nome { get; set; }
        public double Ranual { get; set; }

    public Pessoa(string nome, double ranual)
        {
            Nome = nome;
            Ranual = ranual;
        }


        public abstract double Imposto();
       
    }


}
