
using GestaoDeRevistas.ConsoleApp.Compartilhado;

namespace GestaoDeRevistas.ConsoleApp.ModuloRevista
{
   public class RepositorioRevista
    {
        public static Revista[] revistas = new Revista[100];
        public static int contadorRevistas = 0;


        public void CadastrarRevista (Revista novaRevista)
        {
            novaRevista.IdRevista = GeradorIds.GerarIdRevista();

            revistas[contadorRevistas++] = novaRevista;
        }

        public bool EditarRevista(int idRevista, Revista revistaEditada)
        {
            for (int i = 0; i < revistas.Length; i++)
            {
                if (revistas[i] == null) continue;

                else if (revistas[i].IdRevista == idRevista)
                {
                    revistas[i].Titulo = revistaEditada.Titulo;
                    revistas[i].NumeroEdicao = revistaEditada.NumeroEdicao;
                    revistas[i].AnoPublicacao = revistaEditada.AnoPublicacao;
                    revistas[i].CaixaPertencente = revistaEditada.CaixaPertencente;

                    return true;
                }
            }

            return false;
        }

        public bool ExcluirRevista(int idRevista)
        {
            for (int i = 0; i < revistas.Length; i++)
            {
                if (revistas[i] == null) continue;

                else if (revistas[i].IdRevista == idRevista)
                {
                    revistas[i] = null;

                    return true;
                }
            }

            return false;
        }

        public Revista[] SelecionarRevista()
        {
            return revistas;
        }

        public Revista SelecionarRevistaPorId(int idRevista)
        {
            for (int i = 0; i < revistas.Length; i++)
            {
                Revista revista = revistas[i];

                if (revista == null) continue;

                else if (revista.IdRevista == idRevista)
                    return revista;
            }

            return null;
        }
    }
}
