using System;
using System.Collections.Generic;


namespace ParcialMamalon.Class
{
    public static class Generator //Clase estatica
    {  
        public static int PhoneNumber()//Generador de Numero
        {
            Random numberPhone = new Random();
            int number = numberPhone.Next(60000000, 80000000);
            Console.Write($"Numero Telefonico: {number} ");
            return number;
        }
        public static string Password()//Generador de Contraseña
        {
            Random randomPassword = new Random();
            char letters;
            string characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz1234567890";
            int quantity = characters.Length;
            int passwordlength = 6;
            string clave = string.Empty;
            for ( int i = 0 ; i < passwordlength; i++ )
            {
              letters = characters[randomPassword.Next(quantity)];
              clave += letters.ToString();
            }
            Console.WriteLine($"\nContraseña: {clave}");
            return clave;
        }
        public static int AppleID()//Generador de Numero
        {
            Random numberPhone = new Random(); 
            int number = numberPhone.Next(100000, 900000);
            Console.Write($"AppleID: {number} ");

            return number;
        }

        //Metodo para validar en numero de DUI
        public static bool CheckDui(string dui)
        {
            const string digits = "0123456789";

            if(dui.Length != 10)
            {
            Console.WriteLine("Numero de Dui invalido.");
            return false;
            }

            for(int i = 0; i < dui.Length; i++)
            {
               if((i == 8 && dui[i] != '-') || (i != 8 && !digits.Contains(dui[i])))
                {
                Console.WriteLine("Numero de Dui invalido.");
                return false;
                }
            }
          return true;
        }

        //Metodo para validar el NIT
        public static bool CheckNit(string nit)
        {
            const string digits = "0123456789";

            if(nit.Length != 17)
            {
            Console.WriteLine("Numero de Nit invalido.");
            return false;
            }

            for(int i = 0; i < nit.Length; i++)
            {
            if(((i == 4 || i == 11 || i == 15) && nit[i] != '-') || (i != 4 && i != 11 && i != 15 && !digits.Contains(nit[i])))
            {
                Console.WriteLine("Numero de Nit invalido.");
                return false;
            }
        }
        return true;
        }
    
        //Metodo para calcular el costo por mensaje
        public static double CostsSMS(string message)
        {
           int charactersT = message.Length;

           int whole = charactersT / 20;

           if(charactersT % 20 != 0)
            {
             return (whole + 1) * 0.05;
            }
         return whole * 0.05;
        }
        public static bool CheckNumber(int number) 
        {
          if(number != 8)
          {
            Console.WriteLine("Numero de Telefono invalido (8 digitos).");
            return false;
          }
         return true;
        }
    }  
}