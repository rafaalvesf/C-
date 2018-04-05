//Rafael Ferreira Alves
//Ra: 31725243
// Trabalho: Compilando batalha naval

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bat.Nav
{
    class Program
    {
        public static void Main(string[] args)

        //algumas variaveis do jogo, outras serão acrescentadas ao decorrer do jogo
        {
            int col, lin, nbarco = 1, Cbarco = 5, Dbarco = 5;
            int jogadas = 0;
            string DIR;
            //solicita as informações do primeiro jogador
            Jogador jog1 = new Jogador();
            Console.WriteLine("Digite o nome do Jogador 1");
            jog1.nome = Convert.ToString(Console.ReadLine());
            jog1.id = 1;
            col = 0;
            lin = 0;
            //zera todo o tabuleiro
            jog1.tabuleiro[col, lin] = 0;
            for (col = 0; col < 10; col++)
            {
                for (lin = 0; lin < 10; lin++)
                    jog1.tabuleiro[col, lin] = 0;
            }
            //exemplificando o tabuleiro para o usuário
            Console.WriteLine("Escreva a posição que deseja os navios");
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("    a  b  c  d  e  f  g  h  i  j ");
            Console.WriteLine("1  [ ][ ][ ][ ][ ][ ][ ][ ][ ][ ]");
            Console.WriteLine("2  [ ][ ][ ][ ][ ][ ][ ][ ][ ][ ]");
            Console.WriteLine("3  [ ][ ][ ][ ][ ][ ][ ][ ][ ][ ]");
            Console.WriteLine("4  [ ][ ][ ][ ][ ][ ][ ][ ][ ][ ]");
            Console.WriteLine("5  [ ][ ][ ][ ][ ][ ][ ][ ][ ][ ]");
            Console.WriteLine("6  [ ][ ][ ][ ][ ][ ][ ][ ][ ][ ]");
            Console.WriteLine("7  [ ][ ][ ][ ][ ][ ][ ][ ][ ][ ]");
            Console.WriteLine("8  [ ][ ][ ][ ][ ][ ][ ][ ][ ][ ]");
            Console.WriteLine("9  [ ][ ][ ][ ][ ][ ][ ][ ][ ][ ]");
            Console.WriteLine("10 [ ][ ][ ][ ][ ][ ][ ][ ][ ][ ]");
            Console.WriteLine("-------------------------------------------------");

            //Criando definição das posições dos barcos

            int pcolun = 0;
            int i = 0;
            string letracol;
            do
            {
                do
                {
                    Console.WriteLine("-------------------------------------------------------------------------");
                    Console.WriteLine("O " + nbarco + "° navio tem " + Dbarco + " posições, iremos posicioná-lo.");
                    Console.Write("Digite a Letra referente a coluna: ");
                    letracol = Convert.ToString(Console.ReadLine());   //le a coluna digitada
                    Console.Write("Agora o N° referente a linha: ");
                    lin = int.Parse(Console.ReadLine());               //le a linha digitada
                    switch (letracol)
                    {
                        case "a": pcolun = 0; break;
                        case "b": pcolun = 1; break;
                        case "c": pcolun = 2; break;
                        case "d": pcolun = 3; break;
                        case "e": pcolun = 4; break;           //converte a letra em numero
                        case "f": pcolun = 5; break;
                        case "g": pcolun = 6; break;
                        case "h": pcolun = 7; break;
                        case "i": pcolun = 8; break;
                        case "j": pcolun = 9; break;
                        default: Console.WriteLine("Posição Inválida"); pcolun = 10; break;
                    }
                }
                //condição caso a posição seja invalida
                while (lin - 1 > Cbarco && pcolun > Cbarco || pcolun == 10 || lin > 10 || lin < 1);
                //condição em que a posição possa ser preenchida horizontalmente e verticalmente
                if (lin - 1 <= Cbarco && pcolun <= Cbarco)
                {
                    i = 0;
                    do
                    {
                        Console.WriteLine("Digite (v) para posicionar na vertical e (h) para posicionar na horizontal");
                        DIR = Convert.ToString(Console.ReadLine());                  //condição para posição do barco
                    }
                    while (DIR != "v" && DIR != "h");                                 //consição caso direção seja invalida
                    switch (DIR)
                    {
                        case "h":
                            while (i < Dbarco)
                            {
                                jog1.tabuleiro[pcolun, lin - 1] = 1;                 //caso horizontal a somatoria ocorre nas colunas
                                pcolun = pcolun + 1;
                                i = i + 1;
                            }
                            break;
                        case "v":
                            while (i < Dbarco)
                            {
                                jog1.tabuleiro[pcolun, lin - 1] = 1;                    //caso vertical a somatoria ocorre nas linhas
                                lin = lin + 1;
                                i = i + 1;
                            }
                            break;
                    }
                }
                //caso o barco não couber na vertical, subentende-se sua posição na horizontal
                //caso não couber na horizontal, subentende-se na vertical
                else
                {
                    if (lin - 1 > Cbarco && pcolun <= Cbarco)
                    {
                        Console.WriteLine("Posicionado na Horizontal");
                        jog1.tabuleiro[pcolun, lin - 1] = 1;
                        pcolun = pcolun + 1;
                        i = i + 1;
                    }
                    if (lin - 1 <= Cbarco && pcolun > Cbarco)
                    {
                        Console.WriteLine("Posicionado na Vertical");
                        jog1.tabuleiro[pcolun, lin - 1] = 1;
                        lin = lin + 1;
                        i = i + 1;
                    }
                }

                if (nbarco != 3)
                {
                    Cbarco = Cbarco + 1;
                    Dbarco = Dbarco - 1;                     //variavel somatoria para que limite o numero de posição de barcos
                }
                nbarco = nbarco + 1;
            }
            while (nbarco <= 5);                             //condição para o fim da repetição de posicionamentos dos barcos, significa que ja foram posicionado cinco.

            
            //==================================preparando jogador2
            Console.WriteLine("==================================================================");
            Console.WriteLine("==================================================================");

            Jogador jog2 = new Jogador();
            Console.WriteLine("Digite o nome do Jogador 2");
            jog2.nome = Convert.ToString(Console.ReadLine());
            jog2.id = -1;
            col = 0;
            lin = 0;
            nbarco = 1;
            Cbarco = 5;
            Dbarco = 5;

            jog2.tabuleiro[col, lin] = 0;
            for (col = 0; col < 10; col++)
            {
                for (lin = 0; lin < 10; lin++)
                    jog2.tabuleiro[col, lin] = 0;
            }
            //exemplificando o tabuleiro para o usuário
            Console.WriteLine("Escreva a posição que deseja os navios");
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("    a  b  c  d  e  f  g  h  i  j ");
            Console.WriteLine("1  [ ][ ][ ][ ][ ][ ][ ][ ][ ][ ]");
            Console.WriteLine("2  [ ][ ][ ][ ][ ][ ][ ][ ][ ][ ]");
            Console.WriteLine("3  [ ][ ][ ][ ][ ][ ][ ][ ][ ][ ]");
            Console.WriteLine("4  [ ][ ][ ][ ][ ][ ][ ][ ][ ][ ]");
            Console.WriteLine("5  [ ][ ][ ][ ][ ][ ][ ][ ][ ][ ]");
            Console.WriteLine("6  [ ][ ][ ][ ][ ][ ][ ][ ][ ][ ]");
            Console.WriteLine("7  [ ][ ][ ][ ][ ][ ][ ][ ][ ][ ]");
            Console.WriteLine("8  [ ][ ][ ][ ][ ][ ][ ][ ][ ][ ]");
            Console.WriteLine("9  [ ][ ][ ][ ][ ][ ][ ][ ][ ][ ]");
            Console.WriteLine("10 [ ][ ][ ][ ][ ][ ][ ][ ][ ][ ]");
            Console.WriteLine("-------------------------------------------------");


            //Criando definição das posições dos barcos

            pcolun = 0;
            i = 0;
            do
            {
                do
                {
                    Console.WriteLine("-------------------------------------------------------------------------");
                    Console.WriteLine("O " + nbarco + "° navio tem " + Dbarco + " posições, iremos posicioná-lo.");
                    Console.Write("Digite a Letra referente a coluna: ");
                    letracol = Convert.ToString(Console.ReadLine());
                    Console.Write("Agora o N° referente a linha: ");
                    lin = int.Parse(Console.ReadLine());
                    switch (letracol)
                    {
                        case "a": pcolun = 0; break;
                        case "b": pcolun = 1; break;
                        case "c": pcolun = 2; break;
                        case "d": pcolun = 3; break;
                        case "e": pcolun = 4; break;
                        case "f": pcolun = 5; break;
                        case "g": pcolun = 6; break;
                        case "h": pcolun = 7; break;
                        case "i": pcolun = 8; break;
                        case "j": pcolun = 9; break;
                        default: Console.WriteLine("Posição Inválida"); pcolun = 10; break;
                    }
                }
                //condição caso a posição seja invalida
                while (lin - 1 > Cbarco && pcolun > Cbarco || pcolun == 10 || lin > 10 || lin < 1);
                //condição em que a posição possa ser preenchida horizontalmente e verticalmente
                if (lin - 1 <= Cbarco && pcolun <= Cbarco)
                {
                    i = 0;
                    do
                    {
                        Console.WriteLine("Digite (v) para posicionar na vertical e (h) para posicionar na horizontal");
                        DIR = Convert.ToString(Console.ReadLine());
                    }
                    while (DIR != "v" && DIR != "h");
                    switch (DIR)
                    {
                        case "h":
                            while (i < Dbarco)
                            {
                                jog2.tabuleiro[pcolun, lin - 1] = 1;
                                pcolun = pcolun + 1;
                                i = i + 1;
                            }
                            break;
                        case "v":
                            while (i < Dbarco)
                            {
                                jog2.tabuleiro[pcolun, lin - 1] = 1;
                                lin = lin + 1;
                                i = i + 1;
                            }
                            break;
                    }
                }
                //caso o barco não couber na vertical, subentende-se sua posição na horizontal
                //caso não couber na horizontal, subentende-se na vertical
                else
                {
                    if (lin - 1 > Cbarco && pcolun <= Cbarco)
                    {
                        Console.WriteLine("Posicionado na Horizontal");
                        jog2.tabuleiro[pcolun, lin - 1] = 1;
                        pcolun = pcolun + 1;
                        i = i + 1;
                    }
                    if (lin - 1 <= Cbarco && pcolun > Cbarco)
                    {
                        Console.WriteLine("Posicionado na Vertical");
                        jog2.tabuleiro[pcolun, lin - 1] = 1;
                        lin = lin + 1;
                        i = i + 1;
                    }
                }

                if (nbarco != 3)
                {
                    Cbarco = Cbarco + 1;
                    Dbarco = Dbarco - 1;
                }
                nbarco = nbarco + 1;
            }
            while (nbarco <= 5);

            Console.WriteLine("======@======@@@@@@@@@@@@======@=========@@@@@@=====@=====@===@@@@@@@====");
            Console.WriteLine("=====@=@==========@===========@=@=======@======@====@=====@===@==========");
            Console.WriteLine("====@===@=========@==========@===@======@======@====@=====@===@@@========");
            Console.WriteLine("===@@@@@@@========@=========@@@@@@@=====@======@====@=====@===@@@========");
            Console.WriteLine("==@=======@=======@========@=======@====@====@=@====@=====@===@==========");
            Console.WriteLine("=@=========@======@=======@=========@====@@@@@@=@====@@@@@====@@@@@@@====");
            Console.WriteLine("=========================================================================");
            Console.WriteLine("=========================================================================");
            Console.WriteLine("      Posições para ataque: ");
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("    a  b  c  d  e  f  g  h  i  j ");
            Console.WriteLine("1  [ ][ ][ ][ ][ ][ ][ ][ ][ ][ ]");
            Console.WriteLine("2  [ ][ ][ ][ ][ ][ ][ ][ ][ ][ ]");
            Console.WriteLine("3  [ ][ ][ ][ ][ ][ ][ ][ ][ ][ ]");
            Console.WriteLine("4  [ ][ ][ ][ ][ ][ ][ ][ ][ ][ ]");
            Console.WriteLine("5  [ ][ ][ ][ ][ ][ ][ ][ ][ ][ ]");
            Console.WriteLine("6  [ ][ ][ ][ ][ ][ ][ ][ ][ ][ ]");
            Console.WriteLine("7  [ ][ ][ ][ ][ ][ ][ ][ ][ ][ ]");
            Console.WriteLine("8  [ ][ ][ ][ ][ ][ ][ ][ ][ ][ ]");
            Console.WriteLine("9  [ ][ ][ ][ ][ ][ ][ ][ ][ ][ ]");
            Console.WriteLine("10 [ ][ ][ ][ ][ ][ ][ ][ ][ ][ ]");
            Console.WriteLine("-------------------------------------------------");

            pcolun = 0;
            i = 0;

            int id = 1;

            do
            {
                while(jogadas>3) {
                    Console.WriteLine("      Posições para ataque: ");
                    Console.WriteLine("-------------------------------------------------");
                    Console.WriteLine("    a  b  c  d  e  f  g  h  i  j ");
                    Console.WriteLine("1  [ ][ ][ ][ ][ ][ ][ ][ ][ ][ ]");
                    Console.WriteLine("2  [ ][ ][ ][ ][ ][ ][ ][ ][ ][ ]");
                    Console.WriteLine("3  [ ][ ][ ][ ][ ][ ][ ][ ][ ][ ]");
                    Console.WriteLine("4  [ ][ ][ ][ ][ ][ ][ ][ ][ ][ ]");
                    Console.WriteLine("5  [ ][ ][ ][ ][ ][ ][ ][ ][ ][ ]");
                    Console.WriteLine("6  [ ][ ][ ][ ][ ][ ][ ][ ][ ][ ]");
                    Console.WriteLine("7  [ ][ ][ ][ ][ ][ ][ ][ ][ ][ ]");
                    Console.WriteLine("8  [ ][ ][ ][ ][ ][ ][ ][ ][ ][ ]");
                    Console.WriteLine("9  [ ][ ][ ][ ][ ][ ][ ][ ][ ][ ]");
                    Console.WriteLine("10 [ ][ ][ ][ ][ ][ ][ ][ ][ ][ ]");
                    Console.WriteLine("-------------------------------------------------");
                    jogadas = 0;
                }

                if (id == 1)
                {
                    do
                    {
                        jogadas = jogadas + 1;
                        Console.WriteLine("-------------------------------------------------------------------------");
                        Console.WriteLine("Escolha a posição de ataque " + jog1.nome + ": ");
                        Console.Write("Digite a Letra referente a coluna: ");
                        letracol = Convert.ToString(Console.ReadLine());
                        Console.Write("Agora o N° referente a linha: ");
                        lin = int.Parse(Console.ReadLine());
                        switch (letracol)
                        {
                            case "a": pcolun = 0; break;
                            case "b": pcolun = 1; break;
                            case "c": pcolun = 2; break;
                            case "d": pcolun = 3; break;
                            case "e": pcolun = 4; break;
                            case "f": pcolun = 5; break;
                            case "g": pcolun = 6; break;
                            case "h": pcolun = 7; break;
                            case "i": pcolun = 8; break;
                            case "j": pcolun = 9; break;
                            default: Console.WriteLine("Posição inválida, tente novamente...");pcolun=10 ; break;
                        }
                    }
                    while (pcolun < 0 || pcolun == 10 || lin < 1 || lin > 10);
                    if (jog2.tabuleiro[pcolun, lin - 1] == 2)
                    {
                        Console.WriteLine("----------------------------------------------------");              //condições para reconhecimento de valor da matriz tabuleiro
                        Console.WriteLine("Posição atingida anteriormente, tente outra posição ");
                        Console.WriteLine("----------------------------------------------------");
                    }
                    if (jog2.tabuleiro[pcolun, lin-1] == 1)
                    {
                        Console.WriteLine("-----------------------");
                        Console.WriteLine("Acertou uma embarcação ");
                        Console.WriteLine("-----------------------");
                        jog2.tabuleiro[pcolun, lin - 1] = 2;
                        jog2.navios = jog2.navios - 1;
                    }
                    if (jog2.tabuleiro[pcolun,lin-1]==0)
                    {
                        Console.WriteLine("-----");
                        Console.WriteLine("Errou");
                        Console.WriteLine("-----");
                        id = id * (-1);                                                //alteração de jogador
                        Console.WriteLine("Agora será a vez de " + jog2.nome);
                    }

                    }//fechamento if


                if (id == -1)
                {
                    do
                    {
                        jogadas = jogadas + 1;
                        Console.WriteLine("-------------------------------------------------------------------------");
                        Console.WriteLine("Escolha a posição de ataque " + jog2.nome + ": ");
                        Console.Write("Digite a Letra referente a coluna: ");
                        letracol = Convert.ToString(Console.ReadLine());
                        Console.Write("Agora o N° referente a linha: ");
                        lin = int.Parse(Console.ReadLine());
                        switch (letracol)
                        {
                            case "a": pcolun = 0; break;
                            case "b": pcolun = 1; break;
                            case "c": pcolun = 2; break;
                            case "d": pcolun = 3; break;
                            case "e": pcolun = 4; break;
                            case "f": pcolun = 5; break;
                            case "g": pcolun = 6; break;
                            case "h": pcolun = 7; break;
                            case "i": pcolun = 8; break;
                            case "j": pcolun = 9; break;
                            default: Console.WriteLine("Posição inválida, tente novamente..."); pcolun = 10; break;
                        }
                    }
                    while (pcolun < 0 || pcolun == 10 || lin < 1 || lin > 10);
                    if (jog1.tabuleiro[pcolun, lin - 1] == 2)
                    {
                        Console.WriteLine("----------------------------------------------------");
                        Console.WriteLine("Posição atingida anteriormente, tente outra posição ");
                        Console.WriteLine("----------------------------------------------------");
                    }
                    if (jog1.tabuleiro[pcolun, lin-1] == 1)
                    {
                        Console.WriteLine("-----------------------");
                        Console.WriteLine("Acertou uma embarcação ");
                        Console.WriteLine("-----------------------");
                        jog1.tabuleiro[pcolun, lin - 1] = 2;
                        jog1.navios = jog2.navios - 1;
                    }
                    if (jog1.tabuleiro[pcolun,lin-1]==0)
                    {
                        Console.WriteLine("-----");
                        Console.WriteLine("Errou");
                        Console.WriteLine("-----");
                        id = id * (-1);
                        Console.WriteLine("Agora será a vez de " + jog1.nome);
                    }



                }//fechamento if


            }
            while (jog1.navios != 0 && jog2.navios != 0);
            //fechamento while

            if (jog1.navios==0)                                         //condição para termino do jogo

            {
                Console.WriteLine("*********************************************************************");
                Console.WriteLine("*********************" + jog2.nome + " GANHOU!!! **********************");
                Console.WriteLine("*********************************************************************");
                Console.ReadKey();
            }
            if (jog2.navios == 0)

            {
                Console.WriteLine("*********************************************************************");
                Console.WriteLine("*********************"+jog1.nome + " GANHOU!!! **********************");
                Console.WriteLine("*********************************************************************");
                Console.ReadKey();
            }


        }
    }
}
