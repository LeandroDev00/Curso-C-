using System;
using System.Globalization;

namespace hotelaria
{
    public class Estudante
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public int Rooms { get; set; }

        public Estudante(string name, string email, int rooms)
        {
            this.Name = name;
            this.Email = email;
            this.Rooms = rooms;
        }
    }
}