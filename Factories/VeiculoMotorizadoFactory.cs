using DesafioCarro2.Entities;
using DesafioCarro2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioCarro2.Factories
{
    public class VeiculoMotorizadoFactory : IVeiculoMotorizadoFactory
    {
        public IVeiculoMotorizado BuildVeiculoMotorizado(double peso, double velocidadeLimite, double volumeTanque, IMotor motor)
        {
            return new VeiculoMotorizado(peso, velocidadeLimite, volumeTanque, motor);
        }
    }
}
