using DesafioCarro2.Entities;
using DesafioCarro2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioCarro2.Factories
{
    public class CarroFactory : ICarroFactory
    {
        public ICarro BuildCarro(string modelo, int ano, int numeroPortas, double peso, double velocidadeLimite, double volumeTanque, IMotor motor)
        {
            return new Carro(modelo, ano, numeroPortas, peso, velocidadeLimite, volumeTanque, motor);
        }


    }
}

