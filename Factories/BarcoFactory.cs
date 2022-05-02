using DesafioCarro2.Entities;
using DesafioCarro2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioCarro2.Factories
{
    public class BarcoFactory : IBarcoFactory
    {
        public IBarco BuildBarco(string modelo, int ano, int capacidadePessoas, double comprimento, double peso, double velocidadeLimite, double volumeTanque, IMotor motor)
        {
            return new Barco(modelo, ano, capacidadePessoas, comprimento, peso, velocidadeLimite, volumeTanque, motor);
        }
    }
}
