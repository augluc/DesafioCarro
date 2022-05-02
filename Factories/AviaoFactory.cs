using DesafioCarro2.Entities;
using DesafioCarro2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioCarro2.Factories
{
    public class AviaoFactory : IAviaoFactory
    {
        public IAviao BuildAviao(string modelo, int ano, int capacidadePessoas, double comprimento, double envergadura, double peso, double velocidadeLimite, double volumeTanque, IMotor motor)
        {
            return new Aviao(modelo, ano, capacidadePessoas, comprimento, envergadura, peso, velocidadeLimite, volumeTanque, motor);
        }
    }
}
