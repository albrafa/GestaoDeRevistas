namespace GestaoDeRevistas.ConsoleApp.ModuloCaixa
{

    // O sistema deve permitir cadastrar novas caixas
    // O sistema deve permitir editar caixas existentes
    // O sistema deve permitir excluir caixas
    // O sistema deve permitir visualizar todas as caixas

    //Regras de Negócio:
    // Campos obrigatórios:
    // Etiqueta(texto único, máximo 50 caracteres)
    // Cor(seleção de paleta ou hexadecimal)
    // Dias de empréstimo(número, padrão 7)
    // Não pode haver etiquetas duplicadas
    // Não permitir excluir uma caixa caso tenha revistas vinculadas
    // Cada caixa define o prazo máximo para empréstimo de suas revistas



  public  class Caixa
    {
        public string Etiqueta;
        //cor da caixa
        public DateTime DiasEmprestimo;

    }
}
