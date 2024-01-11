using System;
using System.Collections.Generic;
using System.Linq;

namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placa = Console.ReadLine();

            // Comando para adicionar a placa do veículo à lista de veículos
            // implementado
            veiculos.Add(placa);

            Console.WriteLine($"Veículo {placa} estacionado com sucesso!");
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");
            string placa = Console.ReadLine();

            // Verificação de veículos estacionados
            // implementado
            if (veiculos.Contains(placa))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                int horas = int.Parse(Console.ReadLine());

                // Calculo do valor total a ser pago
                // implementado
                decimal valorTotal = precoInicial + precoPorHora * horas;

                // Remoção do veículo do listado
                // implementado
                veiculos.Remove(placa);

                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                // Exibição dos veículos estacionados
                // implementado
                foreach (var veiculo in veiculos)
                {
                    Console.WriteLine(veiculo);
                }
            }
            else
            { // aviso caso não tenham veiculos estacionados
              // implementado
                Console.WriteLine("Não há veículos estacionados.");
            }
        }

        public void MenuInterativo()
        {
            int opcao;

            do
            {
                Console.WriteLine("Menu Interativo:");
                Console.WriteLine("1. Cadastrar veículo");
                Console.WriteLine("2. Remover veículo");
                Console.WriteLine("3. Listar veículos");
                Console.WriteLine("4. Encerrar");

                // Leitura de opção do usuáro
                // implementado
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        AdicionarVeiculo();
                        break;
                    case 2:
                        RemoverVeiculo();
                        break;
                    case 3:
                        ListarVeiculos();
                        break;
                    case 4:
                        Console.WriteLine("Encerrando o programa...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }

            } while (opcao != 4);
        }
    }
}
