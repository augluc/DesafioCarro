using DesafioCarro2.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioCarro2.Interfaces
{
    public interface ICarro
    {
        string Modelo { get; set; }
        int Ano { get; set; }
        int NumeroPortas { get; set; }
        TipoStatusPorta StatusPorta { get; set; }

        void AbrirPorta();
        void FecharPorta();
        void TocarTokyoDrift();
    }
}
