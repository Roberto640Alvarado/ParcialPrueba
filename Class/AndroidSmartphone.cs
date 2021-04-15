using System;

namespace ParcialMamalon.Class
{
    public class AndroidSmartphone : Smartphone , ISmartphone
    {
        public string brand { get; set; }//marca
        public string model { get; set; }
        public string versionSo { get; set; }

        public AndroidSmartphone(string brand, string model, string versionSo, double currentBalance = 10, 
        double dataNavegation = 1024, double dataRedes = 2048, int ncancion = 1) : base(currentBalance, dataNavegation, dataRedes, ncancion)
        {
            this.brand = brand;
            this.model = model;
            this.versionSo = versionSo;
        }
        public override void PlayMusic()
        {
            bool status = true;
            while(status)
            {
                Console.WriteLine("<<<<<<<<<<<MUSICA EN SPOTIFY>>>>>>>>");
                Console.WriteLine("1) Escucgar una cancion " + "\n2) Regresar" + "\n Opcion: ");
                int option = Int32.Parse(Console.ReadLine());

                switch(option)
                {
                    case 1: 
                    if(ncancion >= 1)
                    {
                        Console.Write("Ingrese el nombre de la cancion: "); 
                        string song = Console.ReadLine();
                        Console.WriteLine($"Reproduciendo la cancion {song} en Spotify");
                        Movements.Add(new Movement(1, $"Reproduccion  {song} en Spotify"));
                        ncancion -= 1;
                    }
    
                    else
                       Console.WriteLine("Ya no tiene canciones disponibles en Spotify");
                    break;
                    case 2: break;
                    default: Console.WriteLine("Opcion No valida"); break;
                }

            }
        }

        public void RechargeBalances()
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

        public void ReloadNavigation()
        {
            bool status = true;
            while(status)
            {
                Console.WriteLine("<<<<<<<<<<<RECARGAR PARA NAVEGACION GENERAL>>>>>>>>");
                Console.WriteLine("1) Recargar Redes Sociales " + "\n2) Recargar Navegacion Web" + "\n3) Regresar" + "\n Opcion: ");
                int option = Int32.Parse(Console.ReadLine());

                switch(option)
                {
                    case 1:MenuRed();break;
                    case 2:MenuNavigation(); break;
                    case 3: break;
                    default: Console.WriteLine("Opcion No valida"); break;
                }
            }
        }

        public void ReloadSongs()
        {
            bool status = true;
            while(status)
            {
                Console.WriteLine("<<<<<<<<<<<RECARGA DE CANCIONES>>>>>>>>");
                Console.WriteLine("1) 200 canciones Spotify ---- $3.00 " + "\n2) Regresar" + "\n Opcion: ");
                int option = Int32.Parse(Console.ReadLine());

                switch(option)
                {
                    case 1: 
                    if(currentBalance >=3)
                    {
                        Console.Write("Se han agregado las 200 canciones en Spotify, a disfrutar..."); 
                        ncancion += 200;
                        Movements.Add(new Movement(3, "Agrego 200 canciones en spotify"));
                    }
    
                    else
                       Console.WriteLine("Insuficiente saldo");
                    break;
                    case 2: break;
                    default: Console.WriteLine("Opcion No valida"); break;
                }

            }
        }

        public void MenuRed()//Metodo para la navegacion en al redes sociales
        {
            bool status = true;
            while(status)
            {
                Console.WriteLine("<<<<<<<<<<<RECARGAR PARA REDES SOCIALES>>>>>>>>");
                Console.WriteLine("1) 500MB para solo redes sociales -------$4.00" + "\n2) Regresar" + "\n Opcion: ");
                int option = Int32.Parse(Console.ReadLine());

                switch(option)
                {
                    case 1: 
                    if(currentBalance >= 4)
                    {
                        Console.Write("Se han agregado 500MB para redes sociales "); 
                        dataRedes += 500;
                        Movements.Add(new Movement(4, "Se agregaron 500MB"));
                    }
    
                    else
                       Console.WriteLine("Saldo Insuficiente");
                    break;
                    case 2: break;
                    default: Console.WriteLine("Opcion No valida"); break;
                }

            }
        }

        public void MenuNavigation()//Metodo en la navegacion de web
        {
            bool status = true;
            while(status)
            {
                Console.WriteLine("<<<<<<<<<<<RECARGAR PARA NAVEGACION EN LA WEB>>>>>>>>");
                Console.WriteLine("1) 500MB para navegacion -------$5.00" + "\n2) Regresar" + "\n Opcion: ");
                int option = Int32.Parse(Console.ReadLine());

                switch(option)
                {
                    case 1: 
                    if(currentBalance >= 4)
                    {
                        Console.Write("Se han agregado 500MB para navegacion web "); 
                        dataNavegation += 500;
                        Movements.Add(new Movement(5, "Se agregaron 500MB navegacion para web"));
                    }
    
                    else
                       Console.WriteLine("Saldo Insuficiente");
                    break;
                    case 2: break;
                    default: Console.WriteLine("Opcion No valida"); break;
                }

            }
        }
    }
}