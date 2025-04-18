using GestaoDeRevistas.ConsoleApp.Compartilhado;
using GestaoDeRevistas.ConsoleApp.ModuloCaixa;

namespace GestaoDeRevistas.ConsoleApp.ModuloRevista
{
    public class TelaRevista
    {
        public static Revista[] revistas = new Revista[100];
        public static int contadorRevistas = 0;

        public int GestaoRevista()
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

            return gestaoRevistas;
        }

        public void CadastroRevista()
        {
            Console.WriteLine("------------------");
            Console.WriteLine("GESTÃO DE REVISTAS");
            Console.WriteLine("------------------");
            Console.WriteLine("Cadastrando nova revista...");
            Console.WriteLine("---------------------------");
            Console.WriteLine();

            Console.WriteLine("Digite o título da revista: ");
            string nomeRevista = Console.ReadLine().Trim();
            Console.WriteLine();

            Console.WriteLine("Digite o número da edição da revista: ");
            int numeroEdicao = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Digite o ano de publicação da revista: ");
            int anoPublicacaoRevista = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Informe a caixa pertencente: ");
            string caixaPertencente = Console.ReadLine().Trim();
            Console.WriteLine();

            Revista novaRevista = new Revista(nomeRevista, numeroEdicao, anoPublicacaoRevista, null);

            revistas[contadorRevistas++] = novaRevista;
            
        }

        public void EditarRevista()
        {
            Console.WriteLine("------------------");
            Console.WriteLine("GESTÃO DE REVISTAS");
            Console.WriteLine("------------------");
            Console.WriteLine();
            Console.WriteLine("Editando revista...");
            Console.WriteLine("-------------------");
            Console.WriteLine();

            VisualizarRevistas(false);

           Console.Write("Digite o ID da revista que deseja editar: ");
            int idRevista = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o título da revista: ");
            string nomeRevista = Console.ReadLine().Trim();
            Console.WriteLine();

            Console.WriteLine("Digite o número da edição da revista: ");
            int numeroEdicao = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Digite o ano de publicação da revista: ");
            int anoPublicacaoRevista = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Informe a caixa pertencente: ");
            string caixaPertencente = Console.ReadLine().Trim();
            Console.WriteLine();

            Revista novaRevista = new Revista(nomeRevista, numeroEdicao, anoPublicacaoRevista, null);

            bool conseguiuEditar = false;

            for (int i = 0; i < revistas.Length; i++)
            {
                if (revistas[i] == null) continue;

                else if (revistas[i].IdRevista == idRevista)
                {
                    revistas[i].Titulo = novaRevista.Titulo;
                    revistas[i].NumeroEdicao = novaRevista.NumeroEdicao;
                    revistas[i].AnoPublicacao = novaRevista.AnoPublicacao;
                    revistas[i].CaixaPertencente = novaRevista.CaixaPertencente;

                    conseguiuEditar = true;
                }

                if (!conseguiuEditar)
                {
                    Console.WriteLine("Ocorreu um erro durante a edição da revista...");
                }

                Console.WriteLine("A revista foi editada com sucesso.");
            }

        }

        public void ExcluirRevista()
        {
            Console.WriteLine("------------------");
            Console.WriteLine("GESTÃO DE REVISTAS");
            Console.WriteLine("------------------------------");
            Console.WriteLine("Excluind revista do sistema...");
            Console.WriteLine("------------------------------");
            Console.WriteLine();

            VisualizarRevistas(false);

            Console.Write("Digite o ID da revista que deseja excluir: ");
            int idSelecionado = Convert.ToInt32(Console.ReadLine());

            bool conseguiuExcluir = false;

            for (int i = 0; i < revistas.Length; i++)
            {
                if (revistas[i] == null) continue;

                else if (revistas[i].IdRevista == idSelecionado)
                {
                    revistas[i] = null;

                    conseguiuExcluir = true;
                }

                if (!conseguiuExcluir)
                {
                    Console.WriteLine("Ocorreu um erro durante a exclusão da revista no sistema...");
                }

                Console.WriteLine();
                Console.WriteLine("A revista foi devidamente excluída do sistema.");
            }
        }

        public void VisualizarRevistas(bool exibirTitulo)
        {
            if (exibirTitulo)
            {
                Console.Clear();
                Console.WriteLine("------------------");
                Console.WriteLine("GESTÃO DE REVISTAS");
                Console.WriteLine("----------------------------------");
                Console.WriteLine("Visualizando estoque de revista...");
                Console.WriteLine("----------------------------------");
                Console.WriteLine();
            }

            Console.WriteLine("{0, -10} | {1, -15} | {2, -8} | {3, -8} | {4, -10} | {5, -8}"+
                              "Id", "Título", "Número Edição", "Ano de Publicação", "Caixa", "Status");

            for (int i = 0; i < revistas.Length; i++)
            {
                Revista revistaSelecionada = revistas[i];

                if (revistaSelecionada == null) continue;

                Console.WriteLine("{0, -10} | {1, -15} | {2, -8} | {3, -8} | {4, -10} | {5, -8}" +
                "0", revistaSelecionada.Titulo, revistaSelecionada.NumeroEdicao, revistaSelecionada.AnoPublicacao, revistaSelecionada.CaixaPertencente, "Status");
            }            
        }

    }
}
