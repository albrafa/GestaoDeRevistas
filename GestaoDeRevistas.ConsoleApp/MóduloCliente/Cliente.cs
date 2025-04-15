namespace GestaoDeRevistas.ConsoleApp.MóduloCliente
{

    // O sistema deve permitir a inserção de novos amigos
    // O sistema deve permitir a edição de amigos já cadastrados
    // O sistema deve permitir excluir amigos já cadastrados
    // O sistema deve permitir visualizar amigos cadastrados
    // O sistema deve permitir visualizar os empréstimos do amigo.


    //    Regras de Negócio:
    // Campos obrigatórios:
    // Nome(mínimo 3 caracteres, máximo 100)
    // Nome do responsável(mínimo 3 caracteres, máximo 100)
    // Telefone(formato validado: (XX) XXXX-XXXX ou (XX) XXXXX-XXXX)
    // Não pode haver amigos com o mesmo nome e telefone.
    // Não permitir excluir um amigo caso tenha empréstimos vinculados

    public class Cliente
    {
        public int Id;
        public string Nome;
        public string NomeResponsavel;
        public int Telefone;
        public string EmprestimosRealizados;


        public Cliente(string nome, string nomeResponsavel, int telefone)
        {
            Nome = nome;
            NomeResponsavel = nomeResponsavel;
            Telefone = telefone;
            //EmprestimosRealizados = emprestimosRealizados;
        }

    }
}
