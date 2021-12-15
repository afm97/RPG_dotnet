using System;
using rpg_dotnet.src.Entities;

namespace Rpg
{

    class Program
    {

        static void Main(string[] args)
        {
            Guerreiro arus = new Guerreiro("Arus", "Guerreiro");
            Mago wedge = new Mago("Wedge", "Mago Negro");
            Inimigo kingMummy = new Inimigo("King Mummy", "Zumbi");
            
            Console.WriteLine(arus.Atacar());
            Console.WriteLine(kingMummy.Atacar());

            if (arus.valorUltimoAtaque == kingMummy.valorUltimoAtaque)
            {
                Console.WriteLine("Empate, ambos deram dano de " + arus.valorUltimoAtaque);

            } else if (arus.valorUltimoAtaque > kingMummy.valorUltimoAtaque)
            {
                kingMummy.ReceberDano(arus.valorUltimoAtaque - kingMummy.valorUltimoAtaque);
                Console.WriteLine(arus.Nome + " Venceu esse round");
            }else
            {
                arus.ReceberDano(kingMummy.valorUltimoAtaque - arus.valorUltimoAtaque);
                Console.WriteLine(kingMummy.Nome + " Venceu esse round");
            }

        }
    }
}