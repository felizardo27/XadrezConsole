
namespace tabuleiro
{
   class Posicao
    {
        public int Linha { get; set; }
        public int Coluna { get; set; }

        public Posicao(int linha, int coluna)
        {
            Linha = linha;
            Coluna = coluna;
        }

        //metodo para definir valores da posicao
        public void DefinirValores(int linha, int coluna)
        {
            Linha  = linha;
            Coluna = coluna;
        }

        public override string ToString()
        {
            return Linha + ", " + Coluna;
        }
    }
}
