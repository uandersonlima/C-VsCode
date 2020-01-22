using Repository;

namespace Library
{
    public class Jogador1 : iJogador
    {
        private readonly string Nome;

        public Jogador1(string nome)
        {
            Nome=nome;
        }
        public string Chuta()
        {
            return $"{Nome} está chutando";
        }
        public string Corre()
        {
            return $"{Nome} está correndo";
        }
        public string Passe()
        {
            return $"{Nome} está passando";
        }
        
        public string FazPontinho()
        {
            return $"{Nome} está ponteando";
        }
        
    }
}