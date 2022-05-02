using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioCarro2.Interfaces
{
    public interface IBarco
    {
        string Modelo { get; set; }
        int Ano { get; set; }
        int CapacidadePessoas { get; set; }
        double Comprimento { get; set; }

        void LancarAncora();

    }
}
