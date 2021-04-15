using System;

namespace ParcialMamalon.Class
{
    public class Smartphone : Phone
    {
        public double dataNavegation { get; set; }
        public double dataRedes { get; set; }
        public int ncancion { get; set; }

        public Smartphone(double currentBalance, double dataNavegation, double dataRedes, //Constructor
        int ncancion) : base(currentBalance)
        {
            this.dataNavegation = dataNavegation;
            this.dataRedes = dataRedes;
            this.ncancion = ncancion;
        }

        public void NavegationWeb()//Navegacion en la Web
        {
            bool status = true;
            while(status)
            {
                Console.WriteLine("<<<<<<<<<<<NAVEGACION EN LA WEB>>>>>>>>");
                Console.WriteLine("1) Navegar en una pagina " + "\n2) Regresar" + "\n Opcion: ");
                int option = Int32.Parse(Console.ReadLine());

                switch(option)
                {
                    case 1: 
                    if(dataNavegation >= 4)
                    {
                        Console.Write("Ingrese el nombre de la pagina a navegar: "); 
                        string webPage = Console.ReadLine();
                        Console.WriteLine($"Historial---pagina web {webPage} ");
                        dataNavegation -= 4; //restando 4 MB
                        Movements.Add(new Movement(4, $"Navegacion en {webPage}"));
                    }
    
                    else
                       Console.WriteLine("No tiene suficiente megas para navegar en la web");
                    break;
                    case 2: break;
                    default: Console.WriteLine("Opcion No valida"); break;
                }

            }
        }

        public void NavegationRedes()//Navegacion en la Redes Sociales
        {
            bool status = true;
            while(status)
            {
                Console.WriteLine("<<<<<<<<<<<NAVEGACION EN LAS REDES SOCIALES>>>>>>>>");
                Console.WriteLine("1) Ingresar a una red social " + "\n2) Regresar" + "\n Opcion: ");
                int option = Int32.Parse(Console.ReadLine());

                switch(option)
                {
                    case 1: 
                        Console.Write("Ingrese el tiempo que estara en la red social en minutos: "); 
                        int time = Int32.Parse(Console.ReadLine());
                        Console.Write("Ingrese el nombre de la Red Social: ");
                        string social = Console.ReadLine();
                      if(dataRedes >= time * 2)
                       {
                        Console.WriteLine($"Ha ingreasado a la red social {social} con sus {time} minutos ");
                        dataRedes -= time * 2;
                        Movements.Add(new Movement(time * 2, $"Navego en la red social {social}"));
                    }
    
                    else
                       Console.WriteLine("No tiene suficiente megas para navegar en las redes sociales ");
                    break;
                    case 2: break;
                    default: Console.WriteLine("Opcion No valida"); break;
                }

            }
        }

        public virtual void PlayMusic()
        {
            Console.WriteLine("<<<<<<<REPRODUCCION DE MUSICA>>>>>>>>");
        }
    }

}