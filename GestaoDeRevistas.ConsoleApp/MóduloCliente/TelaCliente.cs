using GestaoDeRevistas.ConsoleApp.Compartilhado;

namespace GestaoDeRevistas.ConsoleApp.MóduloCliente
{
    public class TelaCliente
    {

        public static Cliente[] listaClientes = new Cliente[100];
        public static int contadorCliente = 0;

        public string ApresentarMenu()
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

            string opcaoEscolhida = Console.ReadLine();

            return opcaoEscolhida;
        }

        public void CadastrarCliente()
        {
            Console.Clear();
            Console.WriteLine("----------------------");
            Console.WriteLine("CLUBE DE LEITURA");
            Console.WriteLine("----------------------");
            Console.WriteLine();

            Console.WriteLine("Cadastrando cliente...");
            Console.WriteLine("----------------------");
            Console.WriteLine();
            Console.Write("Digite o nome do cliente (mínimo 3 caracteres): ");
            string nome = Console.ReadLine().Trim();
            Console.WriteLine();

            Console.Write("Digite o nome do responsável (mínimo 3 carcteres): ");
            string nomeResponsavel = Console.ReadLine().Trim();
            Console.WriteLine();

            Console.Write("Telefone para contato (XX) XXXX-XXXX ou (XX) XXXXX-XXXX): ");
            int telefone = Convert.ToInt32(Console.ReadLine());

            Cliente novoCliente = new Cliente(nome, nomeResponsavel, telefone);

            novoCliente.Id = GeradorIds.GerarIdCliente();

            listaClientes[contadorCliente++] = novoCliente;
        }

        public void EditarCliente()
        {
            Console.Clear();
            Console.WriteLine("----------------------");
            Console.WriteLine("CLUBE DE LEITURA");
            Console.WriteLine("----------------------");
            Console.WriteLine();

            Console.WriteLine("Editando clientes...");
            Console.WriteLine("---------------------------");
            Console.WriteLine();

            VisualizarCliente(false);

            Console.Write("Digite o ID do cliente: ");
            int idSelecionado = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o nome do cliente (mínimo 3 caracteres): ");
            string nome = Console.ReadLine().Trim();
            Console.WriteLine();

            Console.Write("Digite o nome do responsável (mínimo 3 carcteres): ");
            string nomeResponsavel = Console.ReadLine().Trim();
            Console.WriteLine();

            Console.Write("Telefone para contato (XX) XXXX-XXXX ou (XX) XXXXX-XXXX): ");
            int telefone = Convert.ToInt32(Console.ReadLine());

            Cliente novoCliente = new Cliente(nome, nomeResponsavel, telefone);

            bool conseguiuEditar = false;

            for (int i = 0; i < listaClientes.Length; i++)
            {
                if (listaClientes[i] == null) continue;

                else if (listaClientes[i].Id == idSelecionado)
                {
                    listaClientes[i].Nome = novoCliente.Nome;
                    listaClientes[i].NomeResponsavel = novoCliente.NomeResponsavel;
                    listaClientes[i].Telefone = novoCliente.Telefone;

                    conseguiuEditar = true;
                }
            }

            if (!conseguiuEditar)
            {
                Console.WriteLine("Houve um erro durante a edição das informações do cliente...");
            }

            Console.WriteLine("As informações do cliente foram editadas com sucesso.");

        }

        public void ExcluirCliente()
        {
            Console.Clear();
            Console.WriteLine("----------------------");
            Console.WriteLine("CLUBE DE LEITURA");
            Console.WriteLine("----------------------");
            Console.WriteLine();

            Console.WriteLine("Excluindo de cliente...");
            Console.WriteLine("---------------------------");

            VisualizarCliente(false);

            Console.Write("Digite o ID do cliente que deseja excluir: ");
            int idSelecionado = Convert.ToInt32(Console.ReadLine());

            bool conseguiuExcluir = false;

            for (int i = 0; i < listaClientes.Length; i++)
            {
                if (listaClientes[i].Id == null) continue;

                else if (listaClientes[i].Id == idSelecionado)
                {
                    listaClientes[i] = null;

                    conseguiuExcluir = true;
                }

                if (!conseguiuExcluir)
                {
                    Console.WriteLine("Houve um erro durante a exclusão do registro...");
                }

                Console.WriteLine();
                Console.WriteLine("O cliente foi excluído.");
            }

        }

        public void VisualizarCliente(bool exibirTitulo)
        {

            if (exibirTitulo)
            {
                Console.Clear();
                Console.WriteLine("----------------------");
                Console.WriteLine("CLUBE DE LEITURA");
                Console.WriteLine("----------------------");
                Console.WriteLine();

                Console.WriteLine("Visualização de clientes...");
                Console.WriteLine("---------------------------");
            }

            Console.WriteLine();

            Console.WriteLine("{0, -10} | {1, -15} | {2, -15} | {3, -12} | {4, -12}" +
                              "Id", "Nome", "Nome do responsável", "Contato", "Empréstimos");

            for (int i = 0; i < listaClientes.Length; i++)
            {
                Cliente clienteSelecionado = listaClientes[i];

                if (clienteSelecionado == null) continue;

                Console.WriteLine("{0, -10} | {1, -15} | {2, -15} | {3, -12} | {4, -12}" +
                              clienteSelecionado.Id, clienteSelecionado.Nome, clienteSelecionado.NomeResponsavel, clienteSelecionado.Telefone, clienteSelecionado.EmprestimosRealizados);
            }
        }

    }
}
