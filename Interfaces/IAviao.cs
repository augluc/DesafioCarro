using DesafioCarro2.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioCarro2.Interfaces
{
    public interface IAviao
    {
        string Modelo { get; set; }
        int Ano { get; set; }
        int CapacidadePessoas { get; set; }
        double Comprimento { get; set; }
        double Envergadura { get; set; }
        TipoStatusPorta StatusPorta { get; set; }
        bool isVoo { get; set; }

        void AbrirPorta();
        void FecharPorta();
        void Decolar(double velocidade);
        void Pousar();

    }
}
