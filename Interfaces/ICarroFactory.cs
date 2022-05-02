using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioCarro2.Interfaces
{
    public interface ICarroFactory
    {
        ICarro BuildCarro(string modelo, int ano, int numeroPortas, double peso, double velocidadeLimite, double volumeTanque, IMotor motor);
    }
}
