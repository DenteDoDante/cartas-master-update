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
        nathan.setDefesa (10);

        return nathan;
    }

        private static Carta Mae() {
        Carta mae = new Carta();
        mae.setId (3);
        mae.setNome ("Mâe a braba");
        mae.setAtaque (6);
        mae.setDefesa (7);

        return mae;
    }

        private static Carta Riane() {
        Carta riane = new Carta();
        riane.setId (4);
        riane.setNome ("Riane");
        riane.setAtaque (5);
        riane.setDefesa (15);

        return riane;
    }

        private static Carta Ricardao() {
        Carta ricardao = new Carta();
        ricardao.setId (6);
        ricardao.setNome ("Ricardâo");
        ricardao.setAtaque (12);
        ricardao.setDefesa (11);

        return ricardao;
    }
        private static Carta Cookie() {
        Carta cookie = new Carta();
        cookie.setId (7);
        cookie.setNome ("Cookie");
        cookie.setAtaque (5);
        cookie.setDefesa (5);

        return cookie;
    }

        private static Carta LouroJose() {
        Carta Louro_jose = new Carta();
        Louro_jose.setId (8);
        Louro_jose.setNome ("Louro Jose");
        Louro_jose.setAtaque (5);
        Louro_jose.setDefesa (2);

        return Louro_jose;
    }

    public static Carta SemDados() {
        Carta semdados = new Carta();
        semdados.setId (-1);
        semdados.setNome ("Sem Dados");
        semdados.setAtaque (0);
        semdados.setDefesa (0);

        return semdados;
    }

        public static List<Carta> GerarCartas() {
        List<Carta> cartas = new List<Carta>();
        cartas.Add(Richard());
        cartas.Add(Nathan());
        cartas.Add(Mae());
        cartas.Add(Riane());
        cartas.Add(Ricardao());
        cartas.Add(Cookie());
        cartas.Add(LouroJose());

        return cartas;
    }
}
    }

