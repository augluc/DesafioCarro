using DesafioCarro2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioCarro2.Entities
{
    public class VeiculoMotorizado : IVeiculoMotorizado
    {
        public double Peso { get; set; }
        public double Velocidade { get; set; }
        public double VelocidadeLimite { get; set; }
        public double DistanciaPercorrida { get; set; }
        public double NivelCombustivel { get; set; }
        public double VolumeTanque { get; set; }
        public IMotor Motor { get; set; }

        public VeiculoMotorizado(double peso, double velocidadeLimite, double volumeTanque, IMotor motor)
        {
            Peso = peso;
            VelocidadeLimite = velocidadeLimite;
            NivelCombustivel = VolumeTanque;
            VolumeTanque = volumeTanque;
            Motor = motor;
            Velocidade = 0;
            DistanciaPercorrida = 0;
        }

        public void PercorrerDistancia()
        {
            DistanciaPercorrida += Velocidade/5;
        }

        public void ChecarTanque()
        {
            double porcentagemCombustivel = (NivelCombustivel / VolumeTanque) * 100;

            if (NivelCombustivel <= 0)
            {
                Console.WriteLine("Acabou o combustível!");
                Motor.Desligar();
            }
            else if (NivelCombustivel < VolumeTanque * 0.25)
                Console.WriteLine($"CUIDADO: Combustível na reserva!");

            if (NivelCombustivel > 0)
                Console.WriteLine($"Nivel combustível: {porcentagemCombustivel.ToString("F2")}");
        }

        public void Desacelerar()
        {
            if (Velocidade > 0 && NivelCombustivel > 0)
            {
                if (Velocidade - Motor.ConsumirCombustivel(NivelCombustivel, Velocidade) > 0)
                    Velocidade -= (Motor.Potencia / 8);
                else
                    Velocidade = 0;
                NivelCombustivel -= (Motor.ConsumirCombustivel(NivelCombustivel, Velocidade));

                Console.WriteLine($"Desacelerando...\n" +
                    $"Velocidade atual: {Velocidade.ToString("F2")}km/h");
            }
        }

        public void EncherTanque(int tempo)
        {
            if (tempo == 0)
            {
                Console.WriteLine("Completando o tanque.");
                NivelCombustivel = VolumeTanque;
                Velocidade = 0;
                Console.WriteLine("Tanque cheio!");
            }
            else if (NivelCombustivel < VolumeTanque)
            {
                Console.WriteLine("Parando para abastecer!");
                Console.WriteLine("Completando o tanque.");
                NivelCombustivel = VolumeTanque;
                Velocidade = 0;
                Console.WriteLine("Tanque cheio!");
            }
            else Console.WriteLine("O tanque tá cheio amigo, é só acelerar!");

        }

        public void Parar()
        {
            Console.WriteLine("Parando imediatamente!");
            Velocidade = 0;
            Motor.StatusMotor = Enums.TipoStatusMotor.Desligado;
        }

        public void VirarDireita()
        {
            Console.WriteLine("Virando a direita!");
            NivelCombustivel -= (Motor.Potencia / 45);

            Console.WriteLine($"Velocidade atual: {Velocidade.ToString("F2")}km/h");

        }

        public void VirarEsquerda()
        {
            Console.WriteLine("Virando a esquerda!");
            NivelCombustivel -= (Motor.Potencia / 45);

            Console.WriteLine($"Velocidade atual: {Velocidade.ToString("F2")}km/h");

        }

    }
}
