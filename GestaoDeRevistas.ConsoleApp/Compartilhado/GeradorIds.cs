namespace GestaoDeRevistas.ConsoleApp.Compartilhado
{
   public class GeradorIds
    {
        public static int IdClientes = 0;
        public static int IdRevista = 0;
        public static int IdCaixa = 0;

        public static int GerarIdCliente()
        {
            IdClientes++;
            return IdClientes;
        }

        public static int GerarIdRevista()
        {
            IdRevista++;
            return IdRevista;
        }

        public static int GerarIdCaixa()
        {
            IdCaixa++;
            return IdCaixa;
        }
    }
}
