using DesafioCarro2.Entities;
using DesafioCarro2.Factories;
using DesafioCarro2.Interfaces;
using System;
using System.Threading;

namespace DesafioCarro2
{
    public class Program
    {
        private static IAviaoFactory _aviaoFactory;
        private static IBarcoFactory _barcoFactory;
        private static ICarroFactory _carroFactory;
        private static IMotorFactory _motorFactory;

        static Program()
        {
            _aviaoFactory = new AviaoFactory();
            _barcoFactory = new BarcoFactory();
            _carroFactory = new CarroFactory();
            _motorFactory = new MotorFactory();
        }

        static void Main(string[] args)
        {
            int tempo = 0;

            Console.WriteLine("Viajando à Pasárgada!");
            Console.Write("Lista de modalidade de veículos disponíveis:\n" +
                "1 - Avião\n" +
                "2 - Barco\n" +
                "3 - Carro\n" +
                "Digite o número da modalidade desejada: ");

            int numeroModalidade = int.Parse(Console.ReadLine());

            VeiculoMotorizado veiculo = null;

            Console.WriteLine();

            switch (numeroModalidade)
            {
                case 1:
                    Console.WriteLine("Escolha o seu carro:\n" +
                        "1 - Cessna 172 Skyhawk (TecoTeco)\n" +
                        "2 - Embraer Legacy 450 (Jatinho do Neymar)\n" +
                        "3 - Lockheed SR-71 Blackbird (Jato de guerra)");
                    Console.Write("Digite o número do avião desejado: ");
                    int numeroAviao = int.Parse(Console.ReadLine());
                    switch (numeroAviao)
                    {

                        case 1:
                            veiculo = (Aviao)_aviaoFactory.BuildAviao("Cessna 172 Skyhawk", 1956, 8, 10, 18, 350, 302, 250, _motorFactory.BuildMotor(160, Entities.Enums.TipoMotor.Helice));
                            break;
                        case 2:
                            veiculo = (Aviao)_aviaoFactory.BuildAviao("Embraer Legacy 450 (Jatinho do Neymar)", 2018, 12, 20, 20, 8000, 1004, 10000, _motorFactory.BuildMotor(2272, Entities.Enums.TipoMotor.Turbina));
                            break;
                        case 3:
                            veiculo = (Aviao)_aviaoFactory.BuildAviao("Lockheed SR-71 Blackbird", 1990, 2, 10, 10, 8000, 3529, 10000, (Motor)_motorFactory.BuildMotor(6682, Entities.Enums.TipoMotor.Turbina));
                            break;
                        default:
                            Console.WriteLine("Número inválido!");
                            break;
                    }
                    break;
                case 2:
                    Console.WriteLine("Escolha o seu barco:\n" +
                        "1 - Jangadinha com Motor\n" +
                        "2 - Statement! Marine 50’ Catamaran");
                    Console.Write("Digite o número do barco desejado: ");
                    int numeroBarco = int.Parse(Console.ReadLine());
                    switch (numeroBarco)
                    {

                        case 1:
                            veiculo = (Barco)_barcoFactory.BuildBarco("Jangadinha com Motor", 1983, 4, 5, 150, 50, 25, _motorFactory.BuildMotor(40, Entities.Enums.TipoMotor.Popa));
                            break;
                        case 2:
                            veiculo = (Barco)_barcoFactory.BuildBarco("Statement! Marine 50’ Catamaran", 2011, 10, 15, 5000, 300, 358, _motorFactory.BuildMotor(830, Entities.Enums.TipoMotor.Popa));
                            break;
                        default:
                            Console.WriteLine("Número inválido!");
                            break;
                    }
                    break;
                case 3:
                    Console.WriteLine("Escolha o seu carro:\n" +
                        "1 - Chevrolet Opala\n" +
                        "2 - VW Brasília\n" +
                        "3 - Ford Escort XR3i SE 75");
                    Console.Write("Digite o número do carro desejado: ");

                    int numeroCarro = int.Parse(Console.ReadLine());
                    switch (numeroCarro)
                    {

                        case 1:
                            veiculo = (Carro)_carroFactory.BuildCarro("Chevrolet Opala", 1970, 5, 1200, 180, 84, _motorFactory.BuildMotor(125, Entities.Enums.TipoMotor.Ciclomotor));
                            break;
                        case 2:
                            veiculo = (Carro)_carroFactory.BuildCarro("VW Brasília", 1973, 3, 900, 140, 46, _motorFactory.BuildMotor(60, Entities.Enums.TipoMotor.Ciclomotor));
                            break;
                        case 3:
                            veiculo = (Carro)_carroFactory.BuildCarro("Ford Escort XR3i SE 75", 1994, 3, 1000, 190, 65, _motorFactory.BuildMotor(116, Entities.Enums.TipoMotor.Ciclomotor));
                            break;
                        default:
                            Console.WriteLine("Número inválido!");
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("Número inválido!");
                    break;

            }

            Console.WriteLine();

            Console.WriteLine(veiculo.ToString());


            Console.WriteLine();

            if (veiculo is Carro)
            {
                Carro carro = (Carro)veiculo;

                Console.Write("Deseja fechar a porta (s/n)?");
                char charFecharPorta = char.Parse(Console.ReadLine());
                if (charFecharPorta == 's' || charFecharPorta == 'S') carro.FecharPorta();
            }
            else if (veiculo is Aviao)
            {
                Aviao aviao = (Aviao)veiculo;

                Console.Write("Deseja fechar a porta (s/n)?");
                char charFecharPorta = char.Parse(Console.ReadLine());
                if (charFecharPorta == 's' || charFecharPorta == 'S') aviao.FecharPorta();
            }

            Console.Write("Deseja ligar o motor (s/n)?");
            char charLigarMotor = char.Parse(Console.ReadLine());

            if (charLigarMotor == 's' || charLigarMotor == 'S') veiculo.Motor.Ligar();


            Console.WriteLine("Motor: " + veiculo.Motor.StatusMotor.ToString());


            if (veiculo.Motor.StatusMotor == Entities.Enums.TipoStatusMotor.Ligado)
            {

                Console.WriteLine("Vamos pilotar jovem girino!");

                Console.WriteLine();


                Console.WriteLine("Instruções:\n" +
                "UpArrow - Acelerar :)\n" +
                "DownArrow - Desacelerar :(\n" +
                "RightArrow - Vire a direita\n" +
                "LeftArrow - Vire a esquerda\n" +
                "Space - Para encher o tanque\n" +
                "Escape - Parar (Imediatamente)");

                Console.WriteLine();
                veiculo.EncherTanque(tempo);

                while (veiculo.Motor.StatusMotor == Entities.Enums.TipoStatusMotor.Ligado && tempo < 42)
                {

                    var comandoVeiculo = Console.ReadKey(false).Key;

                    Console.WriteLine();

                    switch (comandoVeiculo)
                    {
                        case ConsoleKey.UpArrow:
                            if (veiculo.Velocidade < veiculo.VelocidadeLimite)
                                veiculo.Velocidade = veiculo.Motor.Acelerar(100, veiculo.Velocidade, veiculo.Peso);
                            else
                                veiculo.Velocidade = veiculo.VelocidadeLimite;

                            if (veiculo is Aviao)
                            {
                                Aviao aviao = (Aviao)veiculo;
                                if (aviao.isVoo == false)
                                {
                                    aviao.Decolar(aviao.Velocidade);
                                }
                            }
                            break;
                        case ConsoleKey.DownArrow:
                            veiculo.Desacelerar();
                            break;
                        case ConsoleKey.RightArrow:
                            if (veiculo is Carro)
                            {
                                Carro carro = (Carro)veiculo;
                                carro.TocarTokyoDrift();
                            }
                            veiculo.VirarDireita();
                            break;
                        case ConsoleKey.LeftArrow:
                            veiculo.VirarEsquerda();
                            if (veiculo is Carro)
                            {
                                Carro carro = (Carro)veiculo;
                                carro.TocarTokyoDrift();
                            }
                            break;
                        case ConsoleKey.Spacebar:
                            if (veiculo is Aviao)
                            {
                                Aviao aviao = (Aviao)(veiculo);
                                aviao.Pousar();
                            }
                            veiculo.EncherTanque(tempo);
                            break;
                        case ConsoleKey.Escape:
                            veiculo.Parar();
                            break;
                        default:
                            Console.WriteLine("Tecla inválida");
                            break;
                    }

                    Console.WriteLine();

                    veiculo.NivelCombustivel = veiculo.Motor.ConsumirCombustivel(veiculo.NivelCombustivel, veiculo.Velocidade);

                    veiculo.ChecarTanque();

                    tempo++;

                    veiculo.PercorrerDistancia();

                    Console.WriteLine($"Caramba andamos {veiculo.DistanciaPercorrida.ToString("F2")}Km");
                    Console.WriteLine($"Velocidade atual: {veiculo.Velocidade.ToString("F2")}Km/h");

                    Console.WriteLine();

                }

            }

            if (veiculo is Aviao)
            {
                Aviao aviao = (Aviao)veiculo;
                if (aviao.isVoo == true)
                {
                    aviao.Pousar();
                }
            }


            if (tempo == 42) Console.WriteLine("Chegamos à Pasárgada! :)");
            else Console.WriteLine("Não chegamos ao destino :(");




        }
    }
}
