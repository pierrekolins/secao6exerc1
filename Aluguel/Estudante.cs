using System;

namespace Aluguel
{
    class Estudante
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public Estudante()
        {
        }

        public Estudante(string name, string email)
        {
            Name = name;
            Email = email;
        }

        public override string ToString()
        {
            return Name+", "+Email;
        }
    }
}
