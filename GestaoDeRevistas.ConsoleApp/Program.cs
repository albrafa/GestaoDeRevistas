namespace GestaoDeRevistas.ConsoleApp
{
    internal class Program
    {

        public static ListaClientes[] listaClientes = new ListaClientes[100];
        public static int contadorCliente = 0;

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
                                    string caixaSelecionadaNovaRevista = Console.ReadLine();
                                    Console.WriteLine();

                                    Revista novaRevista = new Revista(nomeRevista, numeroEdicao, anoPublicacaoRevista, caixaSelecionadaNovaRevista);

                                    revistas[contadorRevistas++] = novaRevista;
                                    break;
                                }
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
                        Console.WriteLine("2 - Editar infomrações do cliente: ");
                        Console.WriteLine("3 - Exlcuir cliente: ");
                        Console.WriteLine("4 - Visualizar cliente: ");  // mostrar os empréstimos realizados pelo cliente                        
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
                                Console.WriteLine("----------------------");
                                Console.WriteLine();
                                Console.Write("Digite o nome do cliente (mínimo 3 caracteres): ");
                                string nome = Console.ReadLine();
                                Console.WriteLine();

                                Console.Write("Digite o nome do responsável (mínimo 3 carcteres): ");
                                string nomeResponsavel = Console.ReadLine();
                                Console.WriteLine();

                                Console.Write("Telefone para contato (XX) XXXX-XXXX ou (XX) XXXXX-XXXX): ");
                                int telefone = Convert.ToInt32(Console.ReadLine());

                                ListaClientes novoCliente = new ListaClientes(nome, nomeResponsavel, telefone);

                                listaClientes[contadorCliente++] = novoCliente; 

                                break;

                            case 4:
                                {
                                    Console.Clear();
                                    Console.WriteLine("----------------------");
                                    Console.WriteLine("CLUBE DE LEITURA");
                                    Console.WriteLine("----------------------");
                                    Console.WriteLine();

                                    Console.WriteLine("Visualização de clientes...");
                                    Console.WriteLine("---------------------------");
                                    Console.WriteLine();

                                    Console.WriteLine("{0, -10} | {1, -15} | {2, -15} | {3, -12} | {4, -12}" +
                                                      "Id", "Nome", "Nome do responsável", "Contato", "Empréstimos");
                                    
                                    for (int i = 0; i < listaClientes.Length; i++)
                                    {
                                        ListaClientes clienteSelecionado = listaClientes[i];

                                        if (clienteSelecionado == null) continue;
                                    }

                                    break;
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
