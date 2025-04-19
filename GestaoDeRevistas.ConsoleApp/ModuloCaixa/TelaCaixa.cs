
using GestaoDeRevistas.ConsoleApp.Compartilhado;
using GestaoDeRevistas.ConsoleApp.ModuloRevista;

namespace GestaoDeRevistas.ConsoleApp.ModuloCaixa

    public class TelaCaixa
    {

        public RepositorioRevista repositorioRevista;

        public TelaCaixa(RepositorioRevista repositorioRevista)
        {
            this.repositorioRevista = repositorioRevista;

        }            
    
        public static Caixa[] listaCaixa = new Caixa[100];
        public static int contadorCaixa = 0;


        //public static Caixa[] caixaVermelha = new Caixa[100]; //Super Heróis
        //public static int contadorCaixaVermelha = 0;

        //public static Caixa[] caixaAmarela = new Caixa[100]; //Nacionais
        //public static int contadorCaixaAmarela = 0;

        //public static Caixa[] caixaAzul = new Caixa[100]; //Super Heróis - raridades
        //public static int contadorCaixaAzul = 0;

        //public static Caixa[] caixaRosa = new Caixa[100]; //Nacionais - raridades
        //public static int contadorRosa = 0;

        public TelaCaixa(TelaRevista telaRevista)
        {
            TelaRevista = telaRevista;
        }

        public TelaRevista TelaRevista { get; }

        public string ApresentarMenu()
        {
            Console.Clear();
            Console.WriteLine("---------------");
            Console.WriteLine("GESTÃO DE CAIXAS");
            Console.WriteLine("----------------");
            Console.WriteLine();
            Console.WriteLine("Escolha uma opção:\n");
            Console.WriteLine("1 - Cadastrar uma nova caixa: ");
            Console.WriteLine("2 - Editar caixa: ");
            Console.WriteLine("3 - Excluir caixa: ");
            Console.WriteLine("4 - Visualizar caixas cadastradas: ");
            Console.WriteLine();

            string opcaoEscolhida = Console.ReadLine();

            return opcaoEscolhida;

        }

        public void CadastrarCaixa()
        {
            Console.Clear();
            Console.WriteLine("----------------------");
            Console.WriteLine("CLUBE DE LEITURA");
            Console.WriteLine("----------------------");
            Console.WriteLine();

            Console.WriteLine("Cadastrando caixa...");
            Console.WriteLine("----------------------");
            Console.WriteLine();

            Console.Write("Insira o texto que deverá ser escrito na etiqueta da caixa: ");
            string etiqueta = Console.ReadLine().Trim();
            Console.WriteLine();

            Console.Write("Escolha a cor da caixa: ");
            string corCaixa = Console.ReadLine().Trim();
            Console.WriteLine();

            Console.Write("Informe o número de dias que essa caixa será emprestada (padrão: 7 dias): ");
            string emprestimoCaixa = (Console.ReadLine());

            VisualizarRevistas();

            Console.Write("Digite o ID da revista que deseja selecionar: ");
            int idRevista = Convert.ToInt32(Console.ReadLine());

            Revista revistaSelecionada = repositorioRevista.SelecionarRevistaPorId(idRevista);

            Caixa novaCaixa = new Caixa(etiqueta, corCaixa, emprestimoCaixa);

            novaCaixa.IdCaixa = GeradorIds.GerarIdCaixa();

            listaCaixa[contadorCaixa++] = novaCaixa;

    }

        public void EditarCaixa()
        {
            Console.Clear();
            Console.WriteLine("----------------------");
            Console.WriteLine("CLUBE DE LEITURA");
            Console.WriteLine("----------------------");
            Console.WriteLine();

            Console.WriteLine("Edição de caixas...");
            Console.WriteLine("-------------------------");
            Console.WriteLine();

            VisualizarCaixas(false);

            int idSelecionado = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o novo texto da etiqueta: ");
            string etiqueta = Console.ReadLine().Trim();
            Console.WriteLine();

            Console.Write("Escolha a nova cor da caixa: ");
            string corCaixa = Console.ReadLine().Trim();
            Console.WriteLine();

            Console.Write("Informe o número de dias que essa caixa será emprestada (padrão: 7 dias): ");
            string emprestimoCaixa = (Console.ReadLine()).Trim();

            Caixa novaCaixa = new Caixa(etiqueta, corCaixa, emprestimoCaixa);

            bool conseguiuEditar = false;

            for (int i = 0; i < listaCaixa.Length; i++)
            {
                if (listaCaixa[i] == null) continue;

                else if (listaCaixa[i].IdCaixa == idSelecionado)
                {
                    listaCaixa[i].Etiqueta = novaCaixa.Etiqueta;
                    listaCaixa[i].CorCaixa = novaCaixa.CorCaixa;
                    listaCaixa[i].EmprestimoCaixa = novaCaixa.EmprestimoCaixa;

                    conseguiuEditar = true;
                }

                if (!conseguiuEditar)
                {
                    Console.WriteLine("Houve um erro durante a edição da caixa...");
                }

                Console.WriteLine("As informações da caixa foram editadas com sucesso!");
            }

        }

        public void ExcluirCaixa()
        {
            Console.Clear();
            Console.WriteLine("----------------------");
            Console.WriteLine("CLUBE DE LEITURA");
            Console.WriteLine("----------------------");
            Console.WriteLine();

            Console.WriteLine("Excluindo caixas...");
            Console.WriteLine("-------------------------");
            Console.WriteLine();

            VisualizarCaixas(false);

            Console.Write("Digite o ID da caixa que deseja excluir: ");

            int idSelecionado = Convert.ToInt32(Console.ReadLine);

            bool conseguiuExcluir = false;

            for (int i = 0; i < listaCaixa.Length; i++)
            {
                if (listaCaixa[i].IdCaixa == null) continue;

                else if (listaCaixa[i].IdCaixa == idSelecionado)
                {
                    listaCaixa[i] = null;

                    conseguiuExcluir = true;
                }

                if (!conseguiuExcluir)
                {
                    Console.WriteLine("Houve um erro durante a exclusão da caixa...");
                }

                Console.WriteLine("A caixa foi excluída com sucesso.");
            }

        }

        public void VisualizarCaixas(bool exibirTitulo)
        {

            if (exibirTitulo)
            {
                Console.Clear();
                Console.WriteLine("----------------------");
                Console.WriteLine("CLUBE DE LEITURA");
                Console.WriteLine("----------------------");
                Console.WriteLine();

                Console.WriteLine("Visualização de caixas...");
                Console.WriteLine("-------------------------");
            }

            Console.WriteLine();

            Console.WriteLine("{0, -10} | {1, -12} | {2, -10} | {3, -10}" +
                              "Id", "Etiqueta", "Cor da Caixa", "Dias de empréstimo");

            for (int i = 0; i < listaCaixa.Length; i++)
            {
                Caixa caixaSelecionada = listaCaixa[i];

                if (caixaSelecionada == null) continue;

                Console.WriteLine("{0, -10} | {1, -12} | {2, -10} | {3, -10}" +
                caixaSelecionada.IdCaixa, caixaSelecionada.Etiqueta, caixaSelecionada.CorCaixa, caixaSelecionada.EmprestimoCaixa);

            }
        }

        public void VisualizarRevistas()

        {
            Console.WriteLine("{0, -10} | {1, -15} | {2, -8} | {3, -8} | {4, -10} | {5, -8}" +
                              "Id", "Título", "Número Edição", "Ano de Publicação", "Caixa", "Status");

        Revista[] revistasCadastradas = repositorioRevista.SelecionarRevista();

            for (int i = 0; i < revistasCadastradas.Length; i++)
            {
                Revista revistaSelecionada = revistasCadastradas[i];

                if (revistaSelecionada == null) continue;

                Console.WriteLine("{0, -10} | {1, -15} | {2, -8} | {3, -8} | {4, -10} | {5, -8}" +
                "0", revistaSelecionada.Titulo, revistaSelecionada.NumeroEdicao, revistaSelecionada.AnoPublicacao, revistaSelecionada.CaixaPertencente, "Status");

            }

        }
    }
}