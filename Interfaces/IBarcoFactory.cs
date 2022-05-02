using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioCarro2.Interfaces
{
    public interface IBarcoFactory
    {
        IBarco BuildBarco(string modelo, int ano, int capacidadePessoas, double comprimento, double peso, double velocidadeLimite, double volumeTanque, IMotor motor);
    }
}
