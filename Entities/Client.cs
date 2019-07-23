using System;

namespace ControlePedidos.Entities
{
    class Client
    {
        public string Name { set; get; }
        public string Email { set; get; }
        public DateTime BirthDate { set; get; }

        public Client()
        {
        }

        public Client(string name, string email, DateTime birthDate)
        {
            Name = name;
            Email = email;
            BirthDate = birthDate;
        }
    }
}
