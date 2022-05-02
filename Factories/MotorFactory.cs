using DesafioCarro2.Entities;
using DesafioCarro2.Entities.Enums;
using DesafioCarro2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioCarro2.Factories
{
    public class MotorFactory : IMotorFactory
    {
        public IMotor BuildMotor(double potencia, TipoMotor tipoMotor)
        {
            return new Motor(potencia, tipoMotor);
        }
    }
}
