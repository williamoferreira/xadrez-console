using System;
using tabuleiro;

namespace xadrez
{
    class PartidaDeXadrez
    {
        private Tabuleiro tab;
        private int turno;
        private Cor JogadorAtual;

        public PartidaDeXadrez()
        {
            tab = new Tabuleiro(8, 8);
            turno = 1;
            JogadorAtual = Cor.Branca;
        }

        public void executarMovimento(Posicao origem, Posicao destino)
        {
            Peca p = tab.retirarPeca(origem);
            p.incrementarQtdeMovimentos();
            tab.retirarPeca(destino);

        }
    }
}
