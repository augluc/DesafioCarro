using DesafioCarro2.Entities.Enums;
using DesafioCarro2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioCarro2.Entities
{
    public class Carro : VeiculoMotorizado, ICarro
    {

        public string Modelo { get; set; }
        public int Ano { get; set; }
        public int NumeroPortas { get; set; }
        public TipoStatusPorta StatusPorta { get; set; }

        public Carro(string modelo, int ano, int numeroPortas, double peso, double velocidadeLimite, double volumeTanque, IMotor motor) : base(peso, velocidadeLimite, volumeTanque, motor)
        {
            Modelo = modelo;
            Ano = ano;
            NumeroPortas = numeroPortas;
            StatusPorta = TipoStatusPorta.Aberta;
        }

        public void AbrirPorta()
        {
            if (StatusPorta == TipoStatusPorta.Fechada)
            {
                StatusPorta = TipoStatusPorta.Aberta;
                Console.WriteLine("Porta aberta com sucesso!");
            }
            else Console.WriteLine("A porta já está aberta");
        }

        public void FecharPorta()
        {
            if (StatusPorta == TipoStatusPorta.Aberta)
            {
                StatusPorta = TipoStatusPorta.Fechada;
                Console.WriteLine("Porta fechada com sucesso!");
            }
            else Console.WriteLine("A porta já está fechada");
        }

        public void TocarTokyoDrift()
        {
            Console.Beep(466, 400);
            Console.Beep(466, 400);
            Console.Beep(466, 400);
            Console.Beep(466, 400);
            Console.Beep(466, 400);
            Console.Beep(494, 300);
            Console.Beep(622, 300);
            Console.Beep(466, 400);
            Console.Beep(466, 400);
        }

        public override string ToString()
        {
            return $"Ficha Técnica:\n{Modelo} ({Ano})\n" +
                            $"\tVelocidade máxima: {VelocidadeLimite}km/h\n" +
                            $"\tVolume do tanque: {VolumeTanque}L\n" +
                            $"\tNúmero de portas: {NumeroPortas}\n" +
                            $"{Motor.ToString()}";
        }
    }
}
