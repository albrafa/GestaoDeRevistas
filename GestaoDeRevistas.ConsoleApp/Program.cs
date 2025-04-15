using GestaoDeRevistas.ConsoleApp.MóduloCliente;
using GestaoDeRevistas.ConsoleApp.ModuloRevista;

namespace GestaoDeRevistas.ConsoleApp
{
    internal class Program
    {
       public static Revista[] revistas = new Revista[100];
       public  static int contadorRevistas = 0;


        static void Main(string[] args)
        {
            TelaCliente telaCliente = new TelaCliente();
            TelaPrincipal telaPrincipal = new TelaPrincipal();

            while (true)
            {

                int opcaoMenuPrincipal = telaPrincipal.ApresentarMenuPrincipal();                

                switch (opcaoMenuPrincipal)
                {
                    case 1:
                        {
                            Console.WriteLine("------------------");
                            Console.WriteLine("GESTÃO DE REVISTAS");
                            Console.WriteLine("------------------");
                            Console.WriteLine();
                            Console.WriteLine("Escolha uma opção:\n");
                            Console.WriteLine("1 - Cadastrar uma nova revista: ");
                            Console.WriteLine("2 - Editar revista: ");
                            Console.WriteLine("3 - Excluir revista: ");
                            Console.WriteLine("4 - Visualizar revistas cadastradas: ");

                            int gestaoRevistas = Convert.ToInt32(Console.ReadLine());

                            switch (gestaoRevistas)
                            {
                                case 1:
                                    {
                                        Console.WriteLine("------------------");
                                        Console.WriteLine("GESTÃO DE REVISTAS");
                                        Console.WriteLine("------------------");
                                        Console.WriteLine("Cadastrando nova revista...");
                                        Console.WriteLine("---------------------------");
                                        Console.WriteLine();

                                        Console.WriteLine("Digite o título da revista: ");
                                        string nomeRevista = Console.ReadLine();
                                        Console.WriteLine();

                                        Console.WriteLine("Digite o número da edição da revista: ");
                                        int numeroEdicao = Convert.ToInt32(Console.ReadLine());
                                        Console.WriteLine();

                                        Console.WriteLine("Digite o ano de publicação da revista: ");
                                        int anoPublicacaoRevista = Convert.ToInt32(Console.ReadLine());
                                        Console.WriteLine();

                                        Console.WriteLine("Informe a caixa pertencente: ");
                                        string caixaPertencente = Console.ReadLine();
                                        Console.WriteLine();

                                        Revista novaRevista = new Revista(nomeRevista, numeroEdicao, anoPublicacaoRevista, caixaPertencente);

                                        revistas[contadorRevistas++] = novaRevista;
                                        break;
                                    }
                            }

                            break;
                        }

                    case 2:
                        {

                          string opcaoEscolhida = telaCliente.ApresentarMenu();

                            switch (opcaoEscolhida)
                            {
                                case "1":

                                    telaCliente.CadastrarCliente(); break;

                                case "2":

                                    telaCliente.EditarCliente(); break;

                                case "3":

                                    telaCliente.ExcluirCliente(); break;

                                case "4":
                                    {
                                        telaCliente.VisualizarCliente(true); break;
                                    }

                                default:
                                    Console.WriteLine("Saindo do programa...");
                                    break;
                            }

                            break;
                        }
                }

                Console.ReadLine();
            }
            
        }

    }
}
