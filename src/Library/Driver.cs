using System;
using System.Collections.Generic;

namespace ProyectoAutos
{
    public class Driver : User
    {
        public string Bio { get; set; }
        public Car Car { get; set; }

        public Driver(string name, string surname, string id, double score, string bio, Car car)
            : base(name, surname, id, score)
        {
            Bio = bio;
            Car = car;
        }
    }
}