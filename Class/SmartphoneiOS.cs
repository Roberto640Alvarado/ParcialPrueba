using System;

namespace ParcialMamalon.Class
{
    public class SmartphoneiOS : Smartphone, ISmartphone
    {
        public int AppleiD { get; set; }
        public string versionSo { get; set; }

        public SmartphoneiOS(string versionSo, double currentBalance, double dataNavegation,//constructor
        double dataRedes, int ncancion) : base(currentBalance, dataNavegation, dataRedes, ncancion)
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
                        //Movements.Add(new Movement(1, $"Reproduccion  {song} en Spotify"));
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

        public void RechargeBalances()
        {
            throw new NotImplementedException();
        }

        public void ReloadNavigation()
        {
            throw new NotImplementedException();
        }

        public void ReloadSongs()
        {
            throw new NotImplementedException();
        }
    }
}