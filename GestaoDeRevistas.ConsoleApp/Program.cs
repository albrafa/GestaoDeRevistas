namespace GestaoDeRevistas.ConsoleApp
{
    internal class Program
    {

        public ListaClientes[] listaClientes = new ListaClientes[100];
        public int contadorCliente = 0;


        static void Main(string[] args)
        {
            Console.WriteLine("----------------");
            Console.WriteLine("CLUBE DE LEITURA");
            Console.WriteLine("----------------\n");


            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1 - Cadastrar novo cliente: ");
            Console.WriteLine("4 - Visualizar cliente: ");
            Console.WriteLine();

            int opcaoEscolhida = Convert.ToInt32(Console.ReadLine());


            switch(opcaoEscolhida)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("----------------------");
                    Console.WriteLine("CLUBE DE LEITURA");
                    Console.WriteLine("----------------------");
                    Console.WriteLine();

                    Console.WriteLine("Cadastrando cliente...");
                    Console.WriteLine("--------------------------");
                    Console.WriteLine();
                    Console.Write("Digite o nome do cliente (mínimo 3 caracteres): ");
                    string nome = Console.ReadLine();
                    Console.WriteLine();

                    Console.Write("Digite o nome do responsável (mínimo 3 carcteres): ");
                    Console.ReadLine();
                    Console.WriteLine();

                    Console.Write("Telefone para contato ((XX) XXXX-XXXX ou (XX) XXXXX-XXXX): ");
                    Console.ReadLine();

                    break;
            }

            Console.ReadLine();
        }

    }
}
