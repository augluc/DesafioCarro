using DesafioCarro2.Entities.Enums;
using DesafioCarro2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioCarro2.Entities
{
    public class Aviao : VeiculoMotorizado, IAviao
    {

        public string Modelo { get; set; }
        public int Ano { get; set; }
        public int CapacidadePessoas { get; set; }
        public double Comprimento { get; set; }
        public double Envergadura { get; set; }
        public TipoStatusPorta StatusPorta { get; set; }
        public bool isVoo { get; set; }

        public Aviao(string modelo, int ano, int capacidadePessoas, double comprimento, double envergadura, double peso, double velocidadeLimite, double volumeTanque, IMotor motor) : base(peso, velocidadeLimite, volumeTanque, motor)
        {
            Modelo = modelo;
            Ano = ano;
            CapacidadePessoas = capacidadePessoas;
            Comprimento = comprimento;
            Envergadura = envergadura;
            StatusPorta = TipoStatusPorta.Aberta;
            isVoo = false;
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
        public void Decolar(double velocidade)
        {
            if (velocidade >= 100)
            {
                Console.WriteLine("O avião decolou com sucesso");
                isVoo = true;
            }
            else
                Console.WriteLine("Velocidade mínima de 100km/h para decolagem!");
        }

        public void Pousar()
        {
            Console.WriteLine("O avião pousou com sucesso!");

            Velocidade = 0;
            isVoo = false;
        }

        public override string ToString()
        {
            return $"Ficha Técnica:\n{Modelo} ({Ano})\n" +
                            $"\tVelocidade máxima: {VelocidadeLimite}km/h\n" +
                            $"\tVolume do tanque: {VolumeTanque}L\n" +
                            $"\tCapacidade de Pessoas: {CapacidadePessoas}\n" +
                            $"\tComprimento: {Comprimento}m\n" +
                            $"\tEnvergadura: {Envergadura}m\n" +
                            $"{Motor.ToString()}";
        }
    }
}
