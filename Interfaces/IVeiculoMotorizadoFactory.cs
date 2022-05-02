using DesafioCarro2.Interfaces;

namespace DesafioCarro2
{
    public interface IVeiculoMotorizadoFactory
    {
        IVeiculoMotorizado BuildVeiculoMotorizado(double peso, double velocidadeLimite, double volumeTanque, IMotor motor);
    }
}