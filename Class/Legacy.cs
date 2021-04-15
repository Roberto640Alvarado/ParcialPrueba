using System;

namespace ParcialMamalon.Class
{
    public class Legacy : Phone, IcellLegacy
    {
        public Legacy(double currentBalance ) : base(currentBalance)
        {    
        }

        public void RechargeBalance()
        {
            Console.Write("Introduzca el saldo a recargar:");
            double balance = Double.Parse(Console.ReadLine());
            currentBalance += balance;
            Console.WriteLine($"Se ha recargado {currentBalance} a su Telefono");
            //Movements.Add(new Movement(balance , "Recargar de saldo"));
        }
    }
}