namespace GestaoDeRevistas.ConsoleApp
{
   public class GeradorIds
    {
        public static int IdClientes = 0;

        public static int GerarIdCliente()
        {
            IdClientes++;
            return IdClientes;
        }


        public static Guid GerarGuidCliente()
        {
            return Guid.NewGuid();
        }

    }
}
