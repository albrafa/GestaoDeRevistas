namespace GestaoDeRevistas.ConsoleApp
{
    internal class Program
    {

        public ListaClientes[] listaClientes = new ListaClientes[100];
        public int contadorCliente = 0;

       public static Revista[] revistas = new Revista[100];
       public  static int contadorRevistas = 0;


        static void Main(string[] args)
        {
            Console.WriteLine("----------------");
            Console.WriteLine("CLUBE DE LEITURA");
            Console.WriteLine("----------------");
            Console.WriteLine();
            Console.WriteLine("Selecione a opção desejada: ");
            Console.WriteLine("1 - Controle de revistas: ");
            Console.WriteLine("2 - Controle de clientes: ");
            Console.WriteLine("3 - Controle de caixas: ");
            Console.WriteLine("4 - Empréstimos e Devoluções: ");

            int opcaoMenuPrincipal = Convert.ToInt32(Console.ReadLine()); 


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

                        string gestaoRevistas = Console.ReadLine();

                        if (gestaoRevistas == "1")
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
                            string anoPublicacaoRevista = Console.ReadLine();
                            Console.WriteLine();

                            Console.WriteLine("Informe a caixa pertencente: ");
                            string caixaSelecionadaNovaRevista = Console.ReadLine();
                            Console.WriteLine();

                            Revista novaRevista = new Revista(nomeRevista, numeroEdicao, anoPublicacaoRevista, caixaSelecionadaNovaRevista);

                            revistas[contadorRevistas++] = novaRevista;
                        }

                        break;
                    }

                case 2:
                    {

                        Console.WriteLine("--------------------");
                        Console.WriteLine("CONTROLE DE CLIENTES");
                        Console.WriteLine("--------------------");
                        Console.WriteLine("Escolha uma opção:");
                        Console.WriteLine("1 - Cadastrar novo cliente: ");
                        Console.WriteLine("4 - Visualizar cliente: ");
                        Console.WriteLine();

                        int opcaoEscolhida = Convert.ToInt32(Console.ReadLine());


                        switch (opcaoEscolhida)
                        {
                            case 1:
                                Console.Clear();
                                Console.WriteLine("----------------------");
                                Console.WriteLine("CLUBE DE LEITURA");
                                Console.WriteLine("----------------------");
                                Console.WriteLine();

                                Console.WriteLine("Cadastrando cliente...");
                                Console.WriteLine("--------------------------");
                                Console.WriteLine();
                                Console.Write("Digite o nome do cliente (mínimo 3 caracteres): ");
                                string nome = Console.ReadLine();
                                Console.WriteLine();

                                Console.Write("Digite o nome do responsável (mínimo 3 carcteres): ");
                                Console.ReadLine();
                                Console.WriteLine();

                                Console.Write("Telefone para contato ((XX) XXXX-XXXX ou (XX) XXXXX-XXXX): ");
                                Console.ReadLine();

                                break;

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
