using System;

namespace ParcialMamalon.Class
{
    public class Movement
    {
        public double Valor { get; set; }
        public string Concepto { get; set; }

       public Movement(double Valor, string Concepto)
       {
           this.Concepto = Concepto;
           this.Valor = Valor;
       }
    }
}