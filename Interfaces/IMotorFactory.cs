using DesafioCarro2.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioCarro2.Interfaces
{
    public interface IMotorFactory
    {
        IMotor BuildMotor(double potencia, TipoMotor tipoMotor);
    }
}
