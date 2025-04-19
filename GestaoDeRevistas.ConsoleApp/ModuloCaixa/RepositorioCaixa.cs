using GestaoDeRevistas.ConsoleApp.Compartilhado;

namespace GestaoDeRevistas.ConsoleApp.ModuloCaixa
{
   public class RepositorioCaixa
    {
        public Caixa[] caixas = new Caixa[100];
        public int contadorCaixas = 0;

        public void CadastrarCaixa(Caixa novaCaixa)
        {
            novaCaixa.IdCaixa = GeradorIds.GerarIdCaixa();
            caixas[contadorCaixas++] = novaCaixa;
        }

        public bool EditarCaixa(int idCaixa, Caixa novaCaixa)
        {
            for (int i = 0; i < caixas.Length; i++)
            {
                if (caixas[i].IdCaixa == null) continue;

                else if (caixas[i].IdCaixa == idCaixa)
                {
                    caixas[i].Etiqueta = novaCaixa.Etiqueta;
                    caixas[i].CorCaixa = novaCaixa.CorCaixa;
                    caixas[i].EmprestimoCaixa = novaCaixa.EmprestimoCaixa;

                    return true;
                }
            }

            return false;
        }

    }
}
