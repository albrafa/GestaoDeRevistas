namespace GestaoDeRevistas.ConsoleApp
{
    // O sistema deve permitir registrar novos empréstimos
    // O sistema deve permitir registrar devoluções
    // O sistema deve permitir visualizar empréstimos abertos e fechados


    // Regras de Negócio:
    //    Campos obrigatórios:
    // Amigo
    // Revista(disponível no momento)
    // Data empréstimo(automática)
    // Data devolução(calculada conforme caixa)
    // Status possíveis: Aberto / Concluído / Atrasado
    // Cada amigo só pode ter um empréstimo ativo por vez
    // Empréstimos atrasados devem ser destacados visualmente
    // A data de devolução é calculada automaticamente(data empréstimo + dias da
    //caixa)

   public class Emprestimo
    {
        //cliente
        //revista
        //data empréstimo
        //data devolução

        public string Status;
        public string Situacao;  //regular ou irregular

    }
}
