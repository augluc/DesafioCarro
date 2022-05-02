using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioCarro2.Interfaces
{
    public interface IVeiculoMotorizado
    {
        double Peso { get; set; }
        double Velocidade { get; set; }
        double VelocidadeLimite { get; set; }
        double DistanciaPercorrida { get; set; }
        double NivelCombustivel { get; set; }
        double VolumeTanque { get; set; }
        IMotor Motor { get; set; }

        void Desacelerar();
        void Parar();
        void VirarDireita();
        void VirarEsquerda();
        void PercorrerDistancia();
        void EncherTanque(int tempo);
        void ChecarTanque();
    }
}
