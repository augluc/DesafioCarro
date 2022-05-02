using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioCarro2.Interfaces
{
    public interface IAviaoFactory
    {
        IAviao BuildAviao(string modelo, int ano, int capacidadePessoas, double comprimento, double envergadura, double peso, double velocidadeLimite, double volumeTanque, IMotor motor);
    }
}
