using Library;

namespace Jogo
{
    class Program
    {
        static void Main(string[] args)
        {
            var jogo = new JogoOP(new Jogador1("Ronaldo"), new Jogador2());
            jogo.IniciarJogo();
        }
    }


}
