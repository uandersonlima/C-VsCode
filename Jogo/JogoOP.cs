using System;
using Repository;

namespace Jogo
{

    public class JogoOP
    {
        private readonly iJogador _jogadorA;
        private readonly iJogador _jogadorB;
        public JogoOP(iJogador  jogador1, iJogador jogador2)
        {
            _jogadorA=jogador1;
            _jogadorB=jogador2;
        }
        public void IniciarJogo()
        {
           Console.WriteLine(_jogadorA.Chuta());
           Console.WriteLine(_jogadorA.Corre());
           Console.WriteLine(_jogadorA.Passe());
           Console.WriteLine( _jogadorB.Chuta());
           Console.WriteLine( _jogadorB.Corre());
           Console.WriteLine( _jogadorB.Passe());

        } 
    }
}
