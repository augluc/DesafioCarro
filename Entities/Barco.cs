using DesafioCarro2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioCarro2.Entities
{
    internal class Barco : VeiculoMotorizado, IBarco
    {

        public string Modelo { get; set; }
        public int Ano { get; set; }
        public int CapacidadePessoas { get; set; }
        public double Comprimento { get; set; }

        public Barco(string modelo, int ano, int capacidadePessoas, double comprimento, double peso, double velocidadeLimite, double volumeTanque, IMotor motor) : base(peso, velocidadeLimite, volumeTanque, motor)
        {
            Modelo = modelo;
            Ano = ano;
            CapacidadePessoas = capacidadePessoas;
            Comprimento = comprimento;
        }

        public void LancarAncora()
        {
            Velocidade = 0;
            Console.WriteLine("Âncora lançada com sucesso!");
        }

        public override string ToString()
        {
            return $"Ficha Técnica:\n{Modelo} ({Ano})\n" +
                            $"\tVelocidade máxima: {VelocidadeLimite}km/h\n" +
                            $"\tVolume do tanque: {VolumeTanque}L\n" +
                            $"\tCpacidade de pessoas: {CapacidadePessoas}\n" +
                            $"\tComprimento: {Comprimento}\n" +
                            $"{Motor.ToString()}";
        }
    }
}
