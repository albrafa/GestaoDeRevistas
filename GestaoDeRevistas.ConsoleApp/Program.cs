using GestaoDeRevistas.ConsoleApp.ModuloCaixa;
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
            TelaCaixa telaCaixa = new TelaCaixa(telaRevista);

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
                                        telaRevista.CadastroRevista(); break;
                                    

                                case 2:                                    
                                        telaRevista.EditarRevista(); break;
                                    

                                case 3:                                    
                                        telaRevista.ExcluirRevista(); break;
                                    

                                case 4:                                    
                                        telaRevista.VisualizarRevistas(false); break;                                
                                                                      
                                    
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

                    case 3:
                        {
                            string gestaoCaixa = telaCaixa.ApresentarMenu();

                            switch (gestaoCaixa)
                            {
                                case "1":
                                    telaCaixa.CadastrarCaixa(); break;

                                case "2":
                                    telaCaixa.EditarCaixa(); break;

                                case "3":
                                    telaCaixa.ExcluirCaixa(); break;
                                case "4":
                                    telaCaixa.VisualizarCaixas(true); break;
                            }

                            break;
                        }
                }

                Console.ReadLine();
            }
            
        }

    }
}
