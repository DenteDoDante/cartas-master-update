namespace cartas
{
    class Program
    {
        private static string nomeJogador;
        private static Jogador jogador;
        private static Jogador adversario;

        static void Main(string[] args)
        {
            Console.Title ="Essa familia é muito unida!Card game edition";
            Loading();
            Menu();

            Console.ReadLine();
        }
        private static void Loading()
        {
            Console.WriteLine("Iniciando o jogo...\nDigite seu nome:");
            nomeJogador = Console.ReadLine();
            Console.WriteLine(nomeJogador + " entrou no jogo.\n");
            Console.WriteLine("Carregando suas cartas.\n");
            System.Threading.Thread.Sleep(500);
            Console.WriteLine("Carregando suas cartas..\n");
            System.Threading.Thread.Sleep(500);
            Console.WriteLine("Carregando suas cartas...\n");
            System.Threading.Thread.Sleep(500);
            Console.Clear();
            Console
                .WriteLine("Bem vindo ao jogo " +
                nomeJogador +
                "!\nPressione ENTER para começar");
        }

        private static void Menu()
        {
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Olá " + nomeJogador + "!\n");
            Console.WriteLine("Escolha uma opção:\n1 - Iniciar novo jogo\n2 - Sair");
            string opcao = Console.ReadLine();
            switch (opcao)
            {
                case "1":
                case "new":
                case "novo":
                    {
                        Console.Clear();
                        Console.WriteLine("Iniciando novo jogo...\n\n");
                        novoJogo();
                        break;
                    }
                case "2":
                    Console.WriteLine("Até mais!");
                    break;
                default:
                    {
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        Menu();
                        break;
                    }
            }
        }

        private static void novoJogo()
        {
            //Criamos os jogadores
            jogador = new Jogador(1, "nomeJogador");
            adversario = new Jogador(2, "Adversário");

            // Exibimos as cartas do jogador em mãos
            exibirMao();
            MULLIGAN();

            // Selecionar a carta para jogar na mesa;
            Console.WriteLine("Vida atual =  " + jogador.getVida());
            Console.WriteLine("Vida atual do oponente é =  " + adversario.getVida());
            System.Threading.Thread.Sleep(300);
            Console.WriteLine("Em seu deck a " + jogador.GetGrimorio().Count() + " cards \n" + "No deck do oponente há " + adversario.GetGrimorio().Count() + " cards ");
           
            Console.WriteLine("\nDigite o número da carta que deseja jogar na mesa(1 à 4):");
            string cartaMesa = Console.ReadLine();

            if (cartaMesa == "1")
            {
                Carta carta = jogador.GetCartas()[0];
                verificaResultado(carta, adversario);
            }
            else if (cartaMesa == "2")
            {
                Carta carta = jogador.GetCartas()[1];
                verificaResultado(carta, adversario);
            }
            else if (cartaMesa == "3")
            {
                Carta carta = jogador.GetCartas()[2];
                verificaResultado(carta, adversario);
            }
            else
            {
                Carta carta = jogador.GetCartas()[3];
                verificaResultado(carta, adversario);
            }
        }

        private static void exibirMao()
        {
            Console.WriteLine("Suas cartas são:");

            for (var i = 0; i < jogador.GetCartas().Count(); i++)
            {
                Console.WriteLine(i + 1 + " - " +
                        jogador.GetCartas()[i].getNome() +
                    " - " +
                    jogador.GetCartas()[i].getAtaque() +
                    " de ataque e " +
                    jogador.GetCartas()[i].getDefesa() +
                    " de defesa.\n");
            }
        }
            private static void MULLIGAN()
            {
                Console.WriteLine("FASE DE MULLIGAN");
                Console.WriteLine("Trocar cartas? 1(sim) 2(Não)");
                string escolha = Console.ReadLine();
                switch (escolha)
                {
                    case "1":
                    case "sim":
                    {
                        Console.Clear();
                        jogador.mulligan();
                        exibirMao();
                        break;
                    }
                    case "2":
                    case "nao":
                    case "não":
                    {
                      
                      break;
                    
                    }
                    default:
                    {
                    
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        MULLIGAN();
                        break;
                    }
                    
                    
                }
            }    
        
        
        private static void verificaResultado(Carta cartaJogador, Jogador adversario)
        {

            Carta cartaAdversario = getCartaAdversario(adversario);
            System.Threading.Thread.Sleep(300);

            if (cartaJogador.getAtaque() < cartaAdversario.getDefesa() && cartaAdversario.getAtaque() == cartaJogador.getDefesa() )
            {
                Console.WriteLine("Ninguem tomou dano");
                System.Threading.Thread.Sleep(300);

            }
            else if (cartaJogador.getAtaque() == cartaAdversario.getDefesa() && cartaAdversario.getAtaque() < cartaJogador.getDefesa() )
            {
                Console.WriteLine("Ninguem tomou dano");
                System.Threading.Thread.Sleep(300);
            }
  
           else if (cartaJogador.getAtaque() == cartaAdversario.getDefesa() && cartaAdversario.getAtaque() == cartaJogador.getDefesa())
            {
                Console.WriteLine("Ninguem tomou dano");
                System.Threading.Thread.Sleep(300);

            }
            else if (cartaJogador.getAtaque() < cartaAdversario.getDefesa() && cartaAdversario.getAtaque() < cartaJogador.getDefesa() )
            {
                Console.WriteLine("Ninguem tomou dano");
                System.Threading.Thread.Sleep(300);
            }
            else if (cartaJogador.getAtaque() > cartaAdversario.getDefesa() && cartaAdversario.getAtaque() <= cartaJogador.getDefesa() )
            {
       
                adversario.setVida(adversario.getVida() - (cartaJogador.getAtaque() - cartaAdversario.getDefesa()));

                Console.WriteLine("O oponente tomou  " +  ( cartaJogador.getAtaque() - cartaAdversario.getDefesa() )    + "  de dano");
                System.Threading.Thread.Sleep(300);

                                  
            }
            else if (cartaJogador.getAtaque() < cartaAdversario.getDefesa() && cartaAdversario.getAtaque() > cartaJogador.getDefesa() )
            {
              
              
                jogador.setVida(jogador.getVida() - ( cartaAdversario.getAtaque() - cartaJogador.getDefesa() ));

                Console.WriteLine("Você tomou " + (cartaAdversario.getAtaque() - cartaJogador.getDefesa() )+   "  de dano");
                System.Threading.Thread.Sleep(300);

            }

            else if (cartaJogador.getAtaque()> cartaAdversario.getDefesa() && cartaAdversario.getAtaque()> cartaJogador.getDefesa())
            {
               jogador.setVida(jogador.getVida() - ( cartaAdversario.getAtaque() - cartaJogador.getDefesa() ));
               adversario.setVida(adversario.getVida()- ( cartaJogador.getAtaque() - cartaAdversario.getDefesa()));

                Console.WriteLine("Você tomou " + ( cartaAdversario.getAtaque() - cartaJogador.getDefesa() ) + " e o oponente tomou "  + ( cartaJogador.getAtaque() - cartaAdversario.getDefesa()) + "  de dano"  );
                System.Threading.Thread.Sleep(300);


            }
                //Nome da carta que o oponente jogou (para testes)
                Console.WriteLine(cartaAdversario.getNome());
                System.Threading.Thread.Sleep(300);
            
            if (jogador.getVida() <= 0  &&  adversario.getVida() <= 0 )
            {
                Console.WriteLine("EMPATE!\n");
                Menu();
            }
            else if (jogador.getVida() <= 0)
            {
                Console.WriteLine("Você perdeu\n");
                Menu();
            }
            else if (adversario.getVida() <= 0)
            {
                Console.WriteLine("Você venceu!\n");
                Menu();
            }

            else
            {
                Carta cartaComprada = jogador.comprarCarta();
                Carta cartaCompradaAdversario = adversario.comprarCarta();

                if (cartaComprada.getId() != -1)
                {
                    jogador.GetCartas().Add(cartaComprada);
                    Console.WriteLine("> Você comprou: " + cartaComprada.getNome() + "\nPróximo turmo...\n");
                    adversario.GetCartas().Add(cartaCompradaAdversario);
                    System.Threading.Thread.Sleep(300);
                    jogador.GetCartas().Remove(cartaJogador);
                    adversario.GetCartas().Remove(cartaAdversario);
                    turnoSC();
                }
                else
                {
                    Console.WriteLine("Sem cartas no grimório\nVocê perdeu! Pressione ENTER para continuar.\n");
                    Console.ReadLine();
                    Menu();
                }
            }
              
          
        
        }
        private static void turnoSC()
        {            
            if (jogador.GetGrimorio().Count() <=0 && adversario.GetGrimorio().Count() <=0 )
            {
             Console.WriteLine("Ambos ficaram sem cartas no Grimorio.\nEMPATE!");
             Menu();
            }
            else if (jogador.GetGrimorio().Count() <=0 && adversario.GetGrimorio().Count() > 0 )
            {
             Console.WriteLine("Você ficou sem cartas no Grimorio.\nPERDEU!");
             Menu();
            }
            else if (jogador.GetGrimorio().Count() >0 && adversario.GetGrimorio().Count() <=0 )
            {
             Console.WriteLine("O Adversario ficou sem cartas no Grimorio.\nVENCEU!");
             Menu();
            }

            exibirMao();
            Console.WriteLine("Vida atual =  " + jogador.getVida());
            Console.WriteLine("Vida atual do oponente é =  " + adversario.getVida());
            System.Threading.Thread.Sleep(300);
            Console.WriteLine("Em seu deck a " + jogador.GetGrimorio().Count() + " cards \n" + "No deck do oponente há " + adversario.GetGrimorio().Count() + " cards ");
            System.Threading.Thread.Sleep(300);

            
            Console.WriteLine("\nDigite o número da carta que deseja jogar na mesa(1 à " + ( jogador.GetCartas().Count()  ) + " )");
            string cartaMesa = Console.ReadLine();


            for (var i = 0; i < jogador.GetCartas().Count(); i++)
            {
                if (cartaMesa == (i + 1).ToString())
                {
                    Carta carta = jogador.GetCartas()[i];
                    verificaResultado(carta, adversario);
                }
            }
        }

        private static Carta getCartaAdversario(Jogador adversario)
        {
            Random random = new Random();
            Carta carta = adversario.GetCartas()[random.Next(0, adversario.GetCartas().Count() - 1 )];
            return carta;
        }

        private static void jogarNovamente()
        {
            Console.WriteLine("Deseja Jogar novamente? \n 1 (sim)  2 (nao)");
            string option = Console.ReadLine();
            switch (option)
            {
                case "1":
                    {
                        Console.WriteLine("Voltando ao Menu");
                        System.Threading.Thread.Sleep(500);
                        Menu();
                        break;
                    }
                case "2":
                    {
                        Console.WriteLine("fechando");
                        System.Threading.Thread.Sleep(500);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Comando invalido por favor tente novamente");
                        jogarNovamente();
                        break;
                    }
            }
        }
    }
}

