using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioCarro2.Interfaces
{
    public interface IVeiculo
    {
        double Peso { get; set; }
        double Velocidade { get; set; }
        double VelocidadeLimite { get; set; }
        double DistanciaPercorrida { get; set; }

        void Desacelerar();
        void Parar();
        void VirarDireita();
        void VirarEsquerda();
        double PercorrerDistancia(double tempo);
    }
}
