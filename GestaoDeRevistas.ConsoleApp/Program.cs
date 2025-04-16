using GestaoDeRevistas.ConsoleApp.MóduloCliente;
using GestaoDeRevistas.ConsoleApp.ModuloRevista;

namespace GestaoDeRevistas.ConsoleApp
{
    internal class Program
    {



        static void Main(string[] args)
        {
            TelaCliente telaCliente = new TelaCliente();
            TelaPrincipal telaPrincipal = new TelaPrincipal();
            TelaRevista telaRevista = new TelaRevista();

            while (true)
            {

                int opcaoMenuPrincipal = telaPrincipal.ApresentarMenuPrincipal();                

                switch (opcaoMenuPrincipal)
                {
                    case 1:
                        {

                           int gestaoRevistas = telaRevista.GestaoRevista();                            

                            switch (gestaoRevistas)
                            {
                                case 1:
                                    {
                                        TelaRevista.CadastroRevista(); 

                                        break;
                                    }

                                case 2:
                                    {
                                        TelaRevista.EditarRevista();

                                        break;
                                    }

                                case 3:
                                    {
                                        TelaRevista.ExcluirRevista();
                                        break;
                                    }

                                case 4:
                                    {
                                        TelaRevista.VisualizarRevistas(false);
                                    }
                            }

                            break;
                        }

                    case 2:
                        {

                          string opcaoEscolhida = telaCliente.ApresentarMenu();

                            switch (opcaoEscolhida)
                            {
                                case "1":

                                    telaCliente.CadastrarCliente(); break;

                                case "2":

                                    telaCliente.EditarCliente(); break;

                                case "3":

                                    telaCliente.ExcluirCliente(); break;

                                case "4":
                                   
                                    telaCliente.VisualizarCliente(true); break;                                    

                                default:
                                    Console.WriteLine("Saindo do programa...");
                                    break;
                            }

                            break;
                        }
                }

                Console.ReadLine();
            }
            
        }

    }
}
