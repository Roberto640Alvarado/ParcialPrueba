using System;

namespace ParcialMamalon.Class
{
    public class Legacy : Phone, IcellLegacy
    {
        public Legacy(double currentBalance = 5.5) : base(currentBalance)
        {    
        }

        public void RechargeBalance()
        {
            double balance;
            do{
                Console.Write("Introduzca el saldo a recargar:");
                balance = Double.Parse(Console.ReadLine());
            }while(balance <=0);
            currentBalance += balance;
            Console.WriteLine($"Se ha recargado {currentBalance} a su Telefono");
            Movements.Add(new Movement(balance , "Recargar de saldo"));
        }
    }
}