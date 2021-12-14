namespace cartas
{
    class Jogador
    {
        private int id;

        private string? nome;

        private int vida;

        private List<Carta> cartas;

        private List<Carta> grimorio;

        public Jogador(int id, string? nome) {
            this.id = -1;
            this.nome = "null";
            this.vida = 100;
            this.cartas = pegarCartas(this.grimorio);
        }
        public string getNome() {
            return this.nome;
        }

        public int getVida(){
            return this.vida;
        } 

        public void setVida (int vida){
            this.vida =vida;
        }

        private List<Carta> pegarCartas(List<Carta> grimorio) {
            List<Carta> maoJogador = new List<Carta>();
            Random random = new Random();
            
            for (int i = 0; i < 4; i++) {
                maoJogador.Add(comprarCarta());
            }

            return maoJogador;
        }

        public List<Carta> GetCartas() {
            return this.cartas;
        }

        public List<Carta> GetGrimorio() {

            if(this.grimorio == null) {
                this.grimorio = GeradorDeCartas.GerarCartas();
            }
            return this.grimorio;
        }

        public Carta comprarCarta() {
            if (this.GetGrimorio().Count() > 0) {
              Random random = new Random();
              int valor = random.Next(0, this.grimorio.Count);
              Carta cartaComprada = this.grimorio[valor];
              this.grimorio.Remove(cartaComprada);

              return cartaComprada;
            } else {
                return GeradorDeCartas.SemDados();
            }
        }
    }
}
