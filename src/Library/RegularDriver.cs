using System;
using System.Collections.Generic;

namespace ProyectoAutos
{
    public class RegularDriver : Driver
    {
        public RegularDriver(string name, string surname, string id, double score, string bio, Car car)
            : base(name, surname, id, score, bio, car)
        {
            MaximumPassengers = 3;
        }
    
    public int MaximumPassengers { get; }
    }
}