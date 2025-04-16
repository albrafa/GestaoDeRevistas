using GestaoDeRevistas.ConsoleApp.Compartilhado;
using GestaoDeRevistas.ConsoleApp.ModuloCaixa;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace GestaoDeRevistas.ConsoleApp.ModuloRevista
{
    // O sistema deve permitir cadastrar novas revistas
    // O sistema deve permitir editar revistas existentes
    // O sistema deve permitir excluir revistas
    // O sistema deve permitir visualizar todas as revistas
    // O sistema deve mostrar o status atual(disponível/emprestada/reservada)

    //Regras de Negócio:
    // Campos obrigatórios:
    // Título(2-100 caracteres)
    // Número da edição(número positivo)
    // Ano de publicação(data válida)
    // Caixa(seleção obrigatória)
    // Não pode haver revistas com mesmo título e edição
    // Status possíveis: Disponível / Emprestada / Reservada
    // Ao cadastrar, o status padrão é "Disponível"



   public class Revista
    {
        public int Id;
        public string Titulo;
        public int AnoPublicacao;
        public int NumeroEdicao;
        public Caixa CaixaPertencente;
        public DateTime DataSaida;
        public string StatusRevista; //se está disponível para empréstimo ou se já está reservada


        public Revista(string nomeRevista, int numeroEdicao, int anoPublicacaoRevista, Caixa caixaPertencente)
        {
            //IdRevista = idRevista;
            Titulo = nomeRevista;
            AnoPublicacao = anoPublicacaoRevista;
            NumeroEdicao = numeroEdicao;
            CaixaPertencente = caixaPertencente;
            DataSaida = DateTime.Today;            

        }

        public int TempoEmprestimo()
        {
            TimeSpan tempoEmprestimo = DateTime.Now.Subtract(DataSaida);

            return tempoEmprestimo.Days;
        }

    }
}
