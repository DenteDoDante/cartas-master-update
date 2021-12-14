namespace cartas
{
    class Carta {
        private int id;
        private string? nome;
        private int ataque;
        private int defesa;

        public string? getNome() {
            return this.nome;
        }

        public int getAtaque() {
            return this.ataque;
        }

        public int getDefesa() {
            return this.defesa;
        }

        public int getId() {
            return this.id;
        }

        public void setNome(string? nome) {
            this.nome = nome;
        }
        public void setId(int id) {
            this.id = id;
        }
        public void setDefesa(int defesa) {
            this.defesa = defesa;
        }
        public void setAtaque(int ataque) {
            this.ataque = ataque;   
    }   }
}
