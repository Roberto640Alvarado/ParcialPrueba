using System;

namespace ParcialMamalon.Class
{
    public class User
    {
        public string name { get; set; }
        public string id { get; set; }
        public string nit { get; set; }
        public string birthDate { get; set; }
        public string mail { get; set; }
        public int numbers { get; set; }
        public string password { get; set; }

        public User(string name , string id, string nit, string birthDate, string mail)//Contructor
        {
            this.name = name;
            this.id = id;
            this.nit = nit;
            this.birthDate = birthDate;
            this.mail = mail;
            numbers = Generator.PhoneNumber();
            password = Generator.Password();
        }

        public bool CorrectPassword(string clave)
        {
            if(password==clave)
            {
                Console.WriteLine("Contraseña Correcta");
                return true;
            }

            Console.WriteLine("Contraseña Incorrecta");
            return false;
        }
    }
    
}