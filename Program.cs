using System;
using System.Collections.Generic;


namespace ParcialMamalon.Class
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Legacy> legacies = new List<Legacy>();
            List<AndroidSmartphone> android = new List<AndroidSmartphone>();
            List<SmartphoneiOS> ios = new List<SmartphoneiOS>();

             bool status;
            string name, id, nit, birthDate, mail;
            
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

            bool continuar = true;
            do{
             Console.Write(menu());//Menu 
             int option = Int32.Parse(Console.ReadLine());
            
             switch(option)
             {
                case 1: DeviceTypes(ref legacies, ref android, ref ios ); break;//Diferentes opciones
                case 2: UseDevices(legacies,android,ios);break;
                case 3: ServiceRequest(legacies,android,ios); break;
                case 4: ShoeMovements(newuser,legacies,android,ios); break;
                case 5: continuar = false; break;
                default: Console.WriteLine("Opcion errónea!"); break;
            }
            }while(continuar);
            Console.WriteLine("\nFue un gusto servirle!");

        }

        static void ShoeMovements(User user, List<Legacy>legacies,List<AndroidSmartphone>android, List<SmartphoneiOS>iOS)
        {
            string clave;
            bool status;
            do{
                Console.Write("Ingrese su Contraseña: ");
                clave = Console.ReadLine();
                status = user.CorrectPassword(clave);

            }while(!status);
            Console.WriteLine("<<<<<<<<<MOVIMIENTOS>>>>>>>>>");
            legacies.ForEach(legacy => legacy.Movements.ForEach(mov =>
            Console.WriteLine("Legacy -{0} - {1}", mov.Concepto, mov.Valor)));
            android.ForEach(legacy => legacy.Movements.ForEach(mov =>
            Console.WriteLine("Android -{0} - {1}", mov.Concepto, mov.Valor)));
            iOS.ForEach(legacy => legacy.Movements.ForEach(mov =>
            Console.WriteLine("iOS -{0} - {1}", mov.Concepto, mov.Valor)));
        }

        static void DeviceTypes(ref List<Legacy>legacies, ref List<AndroidSmartphone>android, ref List<SmartphoneiOS>iOS )
        {
            int option;
            string brand, model, versionSo;
            do{
                Console.WriteLine("\n<<<<<<<<<<<<<<<<<<REGISTROS DE DISPOSITIVOS>>>>>>>>>>>>>");
                Console.WriteLine(
                "1) Telefono Legacy \n" +
                "2) Smartphone Android\n" +
                "3) Smartphone iOS\n" +
                "4) Regresar\n" +
                "Opción elegida: ");
                option = Int32.Parse(Console.ReadLine());

                switch(option) 
                {
                    case 1: 
                        Legacy newlegacy = new Legacy();
                        legacies.Add(newlegacy);
                        Console.WriteLine("Felicidades haz adquirido un Legacy");
                    break;
                    case 2:
                        Console.Write("Ingrese la marca del smartphone Android: ");
                        brand = Console.ReadLine();
                        Console.Write("Ingrese el modelo del smartphone Android: ");
                        model = Console.ReadLine();
                        Console.Write("Ingrese la version del smartphone Android: ");
                        versionSo = Console.ReadLine();

                        AndroidSmartphone newAndroid = new AndroidSmartphone(brand,model,versionSo);
                        android.Add(newAndroid);
                        Console.WriteLine("Felicidades haz adquirido un Smartphone Android");
                    break;
                    case 3:
                        Console.Write("Ingrese la version del smartphone iOS: ");
                        versionSo = Console.ReadLine(); 
                        SmartphoneiOS newiOS = new SmartphoneiOS(versionSo);
                        iOS.Add(newiOS);
                        Console.WriteLine("Felicidades haz adquirido un Smartphone iOS");
                    break;
                    case 4: break;
                    default:Console.WriteLine("Opcion errónea!"); break;
                }

            }while(option < 1 || option > 5);
   
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

        static int Optionmenu()
        {
            int option;
            do{
                Console.WriteLine("<<<<<<<<DISPOSITIVO>>>>>>");
                Console.WriteLine(
                "1) Telefono Legacy \n" +
                "2) Smartphone Android\n" +
                "3) Smartphone iOS\n" +
                "4) Regresar\n" +
                "Opción elegida: ");
                option = Int32.Parse(Console.ReadLine());
            }while(option < 1 || option >5);
            return option;
        }
        static void UseDevices(List<Legacy>legacies, List<AndroidSmartphone>android, List<SmartphoneiOS>iOS)
        {
            int minimenu;
            bool continuar = true;
            while(continuar)
            {
                Console.WriteLine("<<<<<<<<<<USO DE DISPOSITIVO>>>>>>>>>>");
                Console.WriteLine("1) Realizar llamdas \n" +
                "2) Enviar SMS\n" +
                "3) Reproducir musica\n" +
                "4) Navegacion web.\n" +
                "5) Navegacion de redes sociales\n" +
                "6) Regresar.\n" +
                "Opción elegida: ");
                int option = Int32.Parse(Console.ReadLine());

                switch(option)
                {
                    case 1: 
                        minimenu = Optionmenu();
                        switch(minimenu)
                        {
                            case 1:
                               legacies[legacies.Count - 1].MakeCall();break;
                            case 2:
                               android[legacies.Count - 1].MakeCall();break;
                            case 3:  
                               iOS[legacies.Count - 1].MakeCall();break;
                            case 4: break;
                        }
                    break;
                    case 2:
                        minimenu = Optionmenu();
                        switch(minimenu)
                        {
                            case 1:
                               legacies[legacies.Count - 1].SendSMS();break;
                            case 2:
                               android[legacies.Count - 1].SendSMS();break;
                            case 3:  
                               iOS[legacies.Count - 1].SendSMS();break;
                            case 4: break;
                        }
                    break;
                    case 3:
                        minimenu = Optionmenu();
                        switch(minimenu)
                        {
                            case 1:
                               Console.WriteLine("Legacy no contiene un reproductor de musica"); break;
                            case 2:
                               android[legacies.Count - 1].PlayMusic();break;
                            case 3:  
                               iOS[legacies.Count - 1].PlayMusic();break;
                            case 4: break;
                        }
                    break;
                    case 4:  
                        minimenu = Optionmenu();
                        switch(minimenu)
                        {
                            case 1:
                               Console.WriteLine("Legacy no puede conectarse al Internet"); break;
                            case 2:
                               android[legacies.Count - 1].NavegationWeb();break;
                            case 3:  
                               iOS[legacies.Count - 1].NavegationWeb();break;
                            case 4: break;
                        }
                    break;
                    case 5:  
                        minimenu = Optionmenu();
                        switch(minimenu)
                        {
                            case 1:
                               Console.WriteLine("Legacy no puede conectarse al Internet y No podra conectarse a las redes sociales"); break;
                            case 2:
                               android[legacies.Count - 1].NavegationRedes();break;
                            case 3:  
                               iOS[legacies.Count - 1].NavegationRedes();break;
                            case 4: break;
                        }
                    break;
                    case 6: continuar = false; break;
                    default: Console.WriteLine("Opcion errónea!"); break;
                }                
            }    
        }

        static void ServiceRequest(List<Legacy>legacies, List<AndroidSmartphone>android, List<SmartphoneiOS>iOS)
        {
            int minimenu;
            bool continuar = true;
            while(continuar)
            {
                Console.WriteLine("<<<<<<<<<<SERVICIOS>>>>>>>>>>");
                Console.WriteLine("1) Recargar saldo \n" +
                "2) Paquete de canciones\n" +
                "3) Paquete de navegacion\n" +
                "4) Regresar.\n" +
                "Opción elegida: ");
                int option = Int32.Parse(Console.ReadLine());

                switch(option)
                {
                    case 1: 
                        minimenu = Optionmenu();
                        switch(minimenu)
                        {
                            case 1:
                               legacies[legacies.Count - 1].RechargeBalance();break;
                            case 2:
                               android[legacies.Count - 1].RechargeBalances();break;
                            case 3:  
                               iOS[legacies.Count - 1].RechargeBalances();break;
                            case 4: break;
                        }
                    break;
                    case 2:
                        minimenu = Optionmenu();
                        switch(minimenu)
                        {
                            case 1:
                               Console.WriteLine("Legacy no puede almacenar canciones");break;
                            case 2:
                               android[legacies.Count - 1].ReloadSongs();break;
                            case 3:  
                               iOS[legacies.Count - 1].ReloadSongs();break;
                            case 4: break;
                        }
                    break;
                    case 3:
                        minimenu = Optionmenu();
                        switch(minimenu)
                        {
                            case 1:
                               Console.WriteLine("Legacy no puede conectarse a internet"); break;
                            case 2:
                               android[legacies.Count - 1].ReloadNavigation();break;
                            case 3:  
                               iOS[legacies.Count - 1].ReloadNavigation();break;
                            case 4: break;
                        }
                    break;
                    case 4: continuar = false; break;
                    default: Console.WriteLine("Opcion errónea!"); break;
                }                

            }
                


            
        }
    }
}
