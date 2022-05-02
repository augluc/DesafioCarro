using DesafioCarro2.Entities.Enums;

namespace DesafioCarro2.Interfaces
{
    public interface IMotor
    {
        double Potencia { get; set; }
        TipoMotor TipoMotor { get; set; }
        TipoStatusMotor StatusMotor { get; set; }

        void Ligar();
        void Desligar();
        double Acelerar(double tempo, double velocidadeAtual, double peso);
        double ConsumirCombustivel(double volumeCombustivel, double velocidadeAtual);

    }
}
