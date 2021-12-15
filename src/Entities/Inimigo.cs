using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace rpg_dotnet.src.Entities
{
    public class Inimigo : Heroi
    {
        public Inimigo(string Nome, string Classe) : base(Nome, Classe)
        {
            this.Nome = Nome;
            this.Classe = Classe;
            this.Nivel = 5;
            this.PontosDeVida = 200;
            this.PontosDeMagia = 0;
        }

        public override string Atacar()
        {
            Random dado = new Random();
            int forcaDoAtaque = this.Nivel + dado.Next(1,11);
            this.valorUltimoAtaque = forcaDoAtaque;
            return this.Nome + " Ataca, gerando dano de " + forcaDoAtaque + "\n";
        }
    }
}