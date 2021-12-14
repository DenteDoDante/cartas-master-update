namespace cartas
{
    class GeradorDeCartas {
        private static Carta Richard() {
        Carta richard = new Carta();
        richard.setId(1);
        richard.setNome("Richard");
        richard.setAtaque(10);
        richard.setDefesa(10);

        return richard;

        }
        private static Carta Nathan() {
        Carta nathan = new Carta();
        nathan.setId (2);
        nathan.setNome ("Nathan");
        nathan.setAtaque (8);
        nathan.setDefesa (3);

        return nathan;
    }

        private static Carta Mae() {
        Carta mae = new Carta();
        mae.setId (2);
        mae.setNome ("Mae a braba");
        mae.setAtaque (10);
        mae.setDefesa (5);

        return mae;
    }

        private static Carta Riane() {
        Carta riane = new Carta();
        riane.setId (2);
        riane.setNome ("Riane");
        riane.setAtaque (5);
        riane.setDefesa (15);

        return riane;
    }

        public static List<Carta> GerarCartas() {
        List<Carta> cartas = new List<Carta>();
        cartas.Add(Richard());
        cartas.Add(Nathan());
        cartas.Add(Mae());
        cartas.Add(Riane());

        return cartas;
    }
}
    }

