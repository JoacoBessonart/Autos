using System;
using System.Collections.Generic;

namespace ProyectoAutos
{
    public class PoolDriver : Driver
    {
        public PoolDriver(string name, string surname, string id, double score, string bio, Car car)
            : base(name, surname, id, score, bio, car)
        {
        }
    }
}