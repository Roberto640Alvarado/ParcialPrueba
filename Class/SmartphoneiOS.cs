using System;

namespace ParcialMamalon.Class
{
    public class SmartphoneiOS : Smartphone, ISmartphone
    {
        public int AppleiD { get; set; }
        public string versionSo { get; set; }

        public SmartphoneiOS(string versionSo, double currentBalance = 10, double dataNavegation = 1024,//constructor
        double dataRedes = 2048, int ncancion = 1) : base(currentBalance, dataNavegation, dataRedes, ncancion)
        {
            AppleiD = Generator.AppleID();
            this.versionSo = versionSo;
        }

        public override void PlayMusic()
        {
            bool status = true;
            while(status)
            {
                Console.WriteLine("<<<<<<<<<<<MUSICA EN ITUNES>>>>>>>>");
                Console.WriteLine("1) Escuchar una cancion " + "\n2) Regresar" + "\n Opcion: ");
                int option = Int32.Parse(Console.ReadLine());

                switch(option)
                {
                    case 1: 
                    if(ncancion >= 1)
                    {
                        Console.Write("Ingrese el nombre de la cancion: "); 
                        string song = Console.ReadLine();
                        Console.WriteLine($"Reproduciendo la cancion {song} en iTunes");
                        Movements.Add(new Movement(1, $"Reproduccion  {song} en iTunes"));
                        ncancion -= 1;
                    }
    
                    else
                       Console.WriteLine("Ya no tiene canciones disponibles en iTunes");
                    break;
                    case 2: break;
                    default: Console.WriteLine("Opcion No valida"); break;
                }

            }
        }
        
        //metodo para recargar saldo 
        public void RechargeBalances()
        {
            double balanceE;
            Console.WriteLine("Cunato saldo desea recargar?");

            do //validacion para comprobar que el saldo no sea negativo
            {

             balanceE = Convert.ToDouble(Console.ReadLine());

            }while(balanceE <= 0);
            
            currentBalance += balanceE;
            Console.WriteLine("El saldo ha sido agreditado a su telefono");
            Movements.Add(new Movement(balanceE, $"Recarga de saldo"));
        }

        //Metodo para recargar para navegar
        public void ReloadNavigation()
        {
            bool status = true;
            while(status)
            {
                Console.WriteLine("----------RECARGAR PARA NAVEGACION GENERAL----------");
                Console.WriteLine("1) Recargar Redes Socieles. \n" +
                "2) Recargar Navegacion General. \n"+
                "Opcion: ");
                int option = Int32.Parse(Console.ReadLine());

                switch(option)
                 {
                  case 1: MenuRed(); break;
                  case 2: MenuWeb(); break;
                  case 3: break;
                  default: Console.WriteLine("Opcion erronea"); break;
                 }
            }
          
        }

        //Metodo para recargar canciones
        public void ReloadSongs()
        {
             int option;

           do
           {    Console.WriteLine("-----Recargar Canciones-----\n" + 
                "1) 200 canciones en Spotify -$3.00\n" +
                "2) Salir\n" +
                "Opción elegida: "); 
                option = Int32.Parse(Console.ReadLine());

                switch(option)
                {
                    case 1:
                    if(currentBalance >= 3)
                    {
                        Console.WriteLine("Se han agregado 200 canciones de Spotify, a disfrutar.....");
                        ncancion += 200;
                        Movements.Add(new Movement(3,"Agrego 200 canciones a Spotify"));
                    }
                    else
                    Console.WriteLine("Su saldo es insuficiente :("); break;

                    case 2: break;
                    default: Console.WriteLine("Opcion erronea"); break;
                }
           }while(option != 1);
        }
        
        //Menu para recargar redes
        public void MenuRed()
        {
            bool status = true;
            while(status)
            {
                Console.WriteLine("----------RECARGAR REDES SOCIALES----------");
                Console.WriteLine("1) 500MB para redes sociales \n "+
                "2) Regresar.");
                int option = Int32.Parse(Console.ReadLine());

                switch(option)
                {
                    case 1:
                    if(currentBalance >= 4)
                    {
                        Console.WriteLine("Se han agregado 500MB para redes sociales ");
                        dataRedes += 500;
                        Movements.Add(new Movement(4,"Se agregaron 500MB para redes sociales"));
                    }
                    else
                    Console.WriteLine("Su saldo es insuficiente"); break;
                    case 2: break;
                    default: Console.WriteLine("Opcion invalida"); break;
                }
            }
        }
        //Menu para recargar navegacion general
        public void MenuWeb()
        {
            bool status = true;
            while(status)
            {
                Console.WriteLine("----------RECARGAR NAVEGACION----------");
                Console.WriteLine("1) 500MB Navegcion general \n "+
                "2) Regresar.");
                int option = Int32.Parse(Console.ReadLine());

                switch(option)
                {
                    case 1:
                    if(currentBalance <= 5)
                    {
                        Console.WriteLine("Se han agregado 500MB para navegacion general ");
                        dataNavegation += 500;
                        Movements.Add(new Movement(5,"Se agregaron 500MB para navegacion general"));
                    }
                    else
                    Console.WriteLine("Su saldo es insuficiente"); break;
                    case 2: break;
                    default: Console.WriteLine("Opcion invalida"); break;
                }

            }
        }
    }
}