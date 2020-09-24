using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tabuleiro
{
    class Tabuleiro
    {
        public int Linhas { get; set; }
        public int Colunas { get; set; }
        private Peca[,] pecas;

        public Tabuleiro(int linhas, int colunas)
        {
            Linhas = linhas;
            Colunas = colunas;
            pecas = new Peca[linhas, colunas];
        }

        public Peca peca(int linha, int coluna)
        {
            return pecas[linha, coluna];
        }

        public void colocarPeca(Peca p, Posicao pos)
        {
            if(existePeca(pos))
            {
                throw new TabuleiroException("Já existe uma peca nessa posicao");
            }
            pecas[pos.linha, pos.coluna] = p;
            p.posicao = pos;
        }

<<<<<<< HEAD
        public Peca retirarPeca(Posicao pos)
        {
            if (pecas[pos.linha, pos.coluna] == null) return null;

            Peca aux = pecas[pos.linha, pos.coluna];
            aux.posicao = null;
            pecas[pos.linha, pos.coluna] = null;
            return aux;
        }


=======
        public bool existePeca(Posicao pos)
        {
            validarPosicao(pos);
            return (peca(pos.linha, pos.coluna) != null);
        }

        public bool posicaoValida(Posicao pos)
        {
            if (pos.linha < 0 || pos.linha >= Linhas || pos.coluna < 0 || pos.coluna >= Colunas)
            {
                return false;
            }
            return true;
        }

        public void validarPosicao(Posicao pos)
        {
            if(!posicaoValida(pos))
            {
                throw new TabuleiroException("Posicao inválida!");
            }
        }
>>>>>>> 2050426f64b15abb52fb41eca6bdce6e3092608d
    }
}
