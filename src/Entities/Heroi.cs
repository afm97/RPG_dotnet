using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace rpg_dotnet.src.Entities
{
    public class Heroi
    {
        public Heroi(string Nome, string Classe)
        {
            this.Nome = Nome;
            this.Classe = Classe;
            this.Nivel = 1;
            this.PontosDeVida = 50;
            this.PontosDeMagia = 50;
        }

        public string Nome{ get; set; }

        public int Nivel { get; set; }

        public int PontosDeVida { get; set; }

        public int PontosDeMagia { get; set; }

        public string Classe { get; set; }

        public string Ficha()
        {
            return "Meu nome é " + this.Nome + "\n"
                + "Nivel: " + this.Nivel + "\n"
                + "Classe: " + this.Classe + "\n"
                + "Pontos de Vida: " + this.PontosDeVida + "\n"
                + "Pontos de Magia: " + this.PontosDeMagia + "\n";
        }

        public int valorUltimoAtaque{ get; set; }

        public virtual string Atacar()
        {
            Random dado = new Random();
            int forcaDoAtaque = this.Nivel + dado.Next(1,21);
            this.valorUltimoAtaque = forcaDoAtaque;
            return this.Nome + " Ataca com sua espada, gerando dano de " + forcaDoAtaque + "\n";
        }

        public void ReceberDano(int danoRecebido)
        {
            this.PontosDeVida  = this.PontosDeVida - danoRecebido;
        }
    }
}