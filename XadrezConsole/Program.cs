using System;
using tabuleiro;
using xadrez;

namespace XadrezConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                
                PartidaDeXadrez partida = new PartidaDeXadrez();

                while (!partida.Terminada)
                {
                    Console.Clear();
                    Tela.ImprimirTabuleiro(partida.Tab);

                    Console.WriteLine();
                    Console.Write("Origem: ");
                    Posicao origem = Tela.LerPosicaoXadrez().ToPosicao();

                    // a partir da posição de origem que o usuário digitou,
                    // vai acessar essa peça de origem que está na posição de origem
                    // vai pegar os MovimentosPossiveis dessa peça e guardar nessa matriz Bool
                    bool[,] posicoesPossiveis = partida.Tab.Peca(origem).MovimentosPossiveis();

                    // limpar a tela e mostrar no tabuleiro os movimentos possíveis
                    Console.Clear();
                    Tela.ImprimirTabuleiro(partida.Tab, posicoesPossiveis);

                    Console.WriteLine();
                    Console.Write("Destino: ");
                    Posicao destino = Tela.LerPosicaoXadrez().ToPosicao();
                
                    partida.ExecutaMovimento(origem, destino);
                }

                
            }
            catch (TabuleiroException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
