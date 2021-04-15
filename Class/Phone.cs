using System;
using System.Collections.Generic;

namespace ParcialMamalon.Class
{
    public abstract class Phone 
    {
        public double currentBalance { get; set; }

        //public List <Movement> Movements { get; set; }

        public Phone(double currentBalance)//Constructor
        {
            this.currentBalance = currentBalance;
            //Movements = new List<Movement>();
        }

        public void MakeCall()
        {

            bool status = true;
            while(status)
            {
                int duration;
                Console.WriteLine("<<<<<<<<<<<REALIZAR LLAMADAS>>>>>>>>");
                Console.WriteLine("1) Llamar " + "\n2) Regresar" + "\n Opcion: ");
                int option = Int32.Parse(Console.ReadLine());

                switch(option)
                {
                    case 1: 
                    do
                    {
                        Console.Write("Ingrese el tiempo que durara su llamada en minutos: "); 
                        duration = Int32.Parse(Console.ReadLine());
                    }while(duration >0);

                    if(duration > 240)
                        Console.WriteLine(" Llamadas que sobrepasan los 240 minutos no estan permitidas");

                    else if(currentBalance >= duration *0.15)
                    {
                        Console.Write("Ingrese el numero a llamar: ");
                        int number = Int32.Parse(Console.ReadLine());
                        Generator.CheckNumber(number);//verificando si tiene 8 digitos
                        Console.WriteLine("llamando...");
                        //Movements.Add(new Movement(duration * 0.15 , $"Llamada realizada a {number}"));
                        currentBalance -= duration *0.15;
                    }
                    else
                       Console.WriteLine("No tiene suficiente saldo");
                    break;
                    case 2: break;
                    default: Console.WriteLine("Opcion No valida"); break;
                }

            }
        }

        //Metodo para enviar mensajes
        public void SendSMS()
        {
          int option = 0;
          string numbersT, SMS;
          double TotalSMS;

          do
          {
              Console.WriteLine("<<<<<<<<<<<<MENSAJERIA>>>>>>>>>>\n" +
              "1. Enviar un Mensaje. \n" +
              "2. Salir. \n" +
              "Opcion: ");
              option = Int32.Parse(Console.ReadLine());

               switch(option)
               {
                  case 1:
                  Console.WriteLine("Digite el mensaje que desea enviar");
                  SMS = Console.ReadLine();
                  TotalSMS = Generator.CostsSMS(SMS);

                  if(SMS.Length > 100)
                  Console.WriteLine("Los mensajes no pueden tener mas de 100 caracteres :(");

                  if(currentBalance >= TotalSMS)
                  {
                  Console.Write("Ingrese el numero de destino: ");
                  numbersT = Console.ReadLine();
                  Console.WriteLine("Mensaje enviado al numero ingresado con exito");
                  //Movements.Add(new Movement(TotalSMS, $"Mensae enviado a {numbersT}"));
                  currentBalance -= TotalSMS;
                  }
                  else
                  Console.WriteLine("No tiene suficiente saldo");

                  break;
                  case 2: break;
                  default : Console.WriteLine("Opcion No valida"); break;
                  } 
                } while (option != 1); 
        }
    }
}