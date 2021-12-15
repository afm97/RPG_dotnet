using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace rpg_dotnet.src.Entities
{
    public class Mago : Heroi
    {
        public Mago(string Nome, string Classe) : base(Nome, Classe)
        {   
            this.Nome = Nome;
            this.Classe = Classe;
            this.PontosDeVida = 25;
            this.PontosDeMagia = 100;
        }

        public override string Atacar()
        {
            Random dado = new Random();
            int forcaDoAtaque = this.Nivel + dado.Next(1,11);
            this.valorUltimoAtaque = forcaDoAtaque;
            return this.Nome + " Ataca com seu cajado, gerando dano de " + forcaDoAtaque + "\n";
        }

        public string Atacar(int bonus) 
        {
            Random dado = new Random();
            int forcaDoAtaque = this.Nivel + dado.Next(1,11) + bonus;
            return this.Nome + " Ataca com seu cajado, com bônus de " + bonus + " , gerando dano de " + forcaDoAtaque + "\n";
        }
    }   
}