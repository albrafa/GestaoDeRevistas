
namespace GestaoDeRevistas.ConsoleApp
{
    public class TelaPrincipal
    {
        public int ApresentarMenuPrincipal()
        {
            Console.Clear();

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

            return opcaoMenuPrincipal;
        }
    }
}