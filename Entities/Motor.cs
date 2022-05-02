using DesafioCarro2.Entities.Enums;
using DesafioCarro2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioCarro2.Entities
{
    public class Motor : IMotor
    {
        public double Potencia { get; set; }
        public TipoMotor TipoMotor { get; set; }
        public TipoStatusMotor StatusMotor { get; set; }

        public Motor(double potencia, TipoMotor tipoMotor)
        {
            Potencia = potencia;
            TipoMotor = tipoMotor;
            StatusMotor = TipoStatusMotor.Desligado;
        }

        public double Acelerar(double tempo, double velocidadeAtual, double peso)
        {
            velocidadeAtual += Potencia * tempo / peso;
            return velocidadeAtual;
        }

        public void Desligar()
        {
            StatusMotor = TipoStatusMotor.Desligado;
        }

        public void Ligar()
        {
            StatusMotor = TipoStatusMotor.Ligado;
        }

        public double ConsumirCombustivel(double volumeCombustivel, double velocidadeAtual)
        {
            double combustivelConsumido = Potencia * velocidadeAtual / 5000;
            volumeCombustivel -= combustivelConsumido;
            return volumeCombustivel;
        }

        public override string ToString()
        {
            return $"Descrição do motor:\n" +
                $"\tTipo do motor: {TipoMotor.ToString()}\n" +
                $"\tStatus do motor: {StatusMotor.ToString()}\n" +
                $"\tPotência: {Potencia.ToString("F2")}";
        }

    }
}
