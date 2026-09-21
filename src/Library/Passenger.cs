using System;
using System.Collections.Generic;

namespace ProyectoAutos
{
    public class Passenger : User
    {
        public Passenger(string name, string surname, string id, double score)
            : base(name, surname, id, score)
        {
        }
    }
}