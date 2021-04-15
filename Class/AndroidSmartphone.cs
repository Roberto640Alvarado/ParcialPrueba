using System;

namespace ParcialMamalon.Class
{
    public class AndroidSmartphone : Smartphone , ISmartphone
    {
        public string brand { get; set; }//marca
        public string model { get; set; }
        public string versionSo { get; set; }

        public AndroidSmartphone(string brand, string model, string versionSo, double currentBalance , 
        double dataNavegation, double dataRedes, int ncancion) : base(currentBalance, dataNavegation, dataRedes, ncancion)
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
                        //Movements.Add(new Movement(1, $"Reproduccion  {song} en Spotify"));
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