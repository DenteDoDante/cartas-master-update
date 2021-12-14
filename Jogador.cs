namespace cartas
{
    class Jogador
    {
        private int id;

        private string? nome;

        private int vida;

        private List<Carta> cartas;

        private List<Carta> grimorio;

        public Jogador(int id, string? nome, List<Carta> grimorio) {
            this.id = -1;
            this.nome = "null";
            this.vida = 100;
            this.cartas = pegarCartas(grimorio);
            this.grimorio =grimorio;
        }

        public string getNome() {
            return this.nome;
        }

        private List<Carta> pegarCartas(List<Carta> grimorio) {
            List<Carta> maoJogador = new List<Carta>();
            Random random = new Random();
            
            for (int i = 0; i < 4; i++) {
                int valor = random.Next(0, grimorio.Count);
                Carta cartaAleatoria = grimorio[valor];
                maoJogador.Add(cartaAleatoria);
                grimorio.Remove(cartaAleatoria);
            }

            return maoJogador;
        }

        public List<Carta> GetCartas() {
            return this.cartas;
        }
    }
}
