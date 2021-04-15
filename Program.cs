using System;
using System.Collections.Generic;


namespace ParcialMamalon.Class
{
    class Program
    {
        static void Main(string[] args)
        {
            RequestData();
            bool continuar = true;
            do{
             Console.Write(menu());//Menu 
             int option = Int32.Parse(Console.ReadLine());
            
             switch(option)
             {
                case 1: DeviceTypes(); break;//Diferentes opciones
                case 2: ; break;
                case 3: ; break;
                case 4: ; break;
                case 5: continuar = false; break;
                default: Console.WriteLine("Opcion errónea!"); break;
            }
            }while(continuar);
            Console.WriteLine("\nFue un gusto servirle!");

        }
        static void RequestData()
        {
            bool status;
            string name, id, nit, birthDate, mail;
            //List<Legacy> legacies = new List<Legacy>();
            //List<AndroidSmartphone> android = new List<AndroidSmartphone>();
            //List<SmartphoneiOS> ios = new List<SmartphoneiOS>();
            
            Console.WriteLine("\n<<<<<<<<<<<<<<REGISTRANDO LOS DATOS DEL CLIENTE>>>>>>>>>>>>>>>");
            Console.Write("Nombre Completo: ");
            name = Console.ReadLine();

            do{
                Console.Write("Numero de DUI: ");
                id = Console.ReadLine();
                status = Generator.CheckDui(id);
            }while(!status);

            do{
                Console.Write("Numero de NIT: ");
                nit = Console.ReadLine();
                status = Generator.CheckNit(nit);
            }while(!status);

            Console.Write("Fecha de Nacimiento (Dia/mes/año): ");
            birthDate = Console.ReadLine();

            Console.Write("Correo Electronico: ");
            mail = Console.ReadLine(); 

            User newuser = new User(name, id, nit, birthDate, mail);
        }

        static int DeviceTypes()
        {
            int option;
            do{
                Console.WriteLine("\n<<<<<<<<<<<<<<<<<<DISPOSITIVOS>>>>>>>>>>>>>");
                Console.WriteLine(
                "1) Telefono Legacy \n" +
                "2) Smartphone Android\n" +
                "3) Smartphone iOS\n" +
                "4) Regresar\n" +
                "Opción elegida: ");
                option = Int32.Parse(Console.ReadLine()); 
            }while(option < 1 || option > 5);

            return option;   
        }
        static string menu()
        {
            return "\n<<<<<<<<<<<MENU DE OPERACIONES TELEFONICAS>>>>>>>>>>>>>>\n" +
            "1) Registro Dispositivo \n" +
            "2) Uso de los dispositivos\n" +
            "3) Solicitudes de Servicios\n" +
            "4) Mostrar Movimientos.\n" +
            "5) Salir.\n" +
            "Opción elegida: ";
        }
        static void Menu2()//posible a modificar las opciones
        {
            bool continuar = true;
            while(continuar)
            {
                //var p = new Phone();
                Console.WriteLine("<<<<<<<<<<>>>>>>>>>>");
                Console.WriteLine("1) Recargar Saldo \n" +
                "2) Llamar\n" +
                "3) Enviar Mensaje\n" +
                "4) Regresar.\n" +
                "Opción elegida: ");
                int option = Int32.Parse(Console.ReadLine());

                switch(option)
                {
                    case 1: // p.Recharge();break;
                    case 2:  break;
                    case 3:  break;
                    case 4: continuar = false; break;
                    default: Console.WriteLine("Opcion errónea!"); break;
                }                

            }
                


            
        }
    }
}
