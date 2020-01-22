using Repository;

namespace Library
{
    public class Jogador2 : iJogador
    {
        public string Chuta()
        {
            return "Maradona está chutando";
        }

        public string Corre()
        {
            return "Maradona está correndo";
        }

        public string Passe()
        {
           return "Maradona está passando";
        }
    }
}