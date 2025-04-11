using static System.Runtime.InteropServices.JavaScript.JSType;

namespace GestaoDeRevistas.ConsoleApp
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
        public string CaixaPertencente;

        
        public Revista(string nomeRevista, int numeroEdicao, int anoPublicacaoRevista, string caixaSelecionadaNovaRevista)
        {
            Titulo = nomeRevista;
            AnoPublicacao = anoPublicacaoRevista;
            NumeroEdicao = numeroEdicao;
            CaixaPertencente = caixaSelecionadaNovaRevista;

        }

    }
}
