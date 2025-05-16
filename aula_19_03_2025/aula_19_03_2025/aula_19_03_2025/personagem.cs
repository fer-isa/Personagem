using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_19_03_2025
{
    internal class personagem
    {
        public string nome { get; set; }
        public string classe { get; set; }

        public int level { get; set; }

        public int hp { get; set; }

        public int mp { get; set; }

        public personagem(string nome, string classe, int level, int hp, int mp)
        {
            this.nome = nome;
            this.classe = classe;
            this.level = level;
            this.hp = hp;
            this.mp = mp;
        }

        public personagem(string nome, string classe, int level)
        {
            this.nome = nome;
            this.classe = classe;
            this.level = level;
        }

        //public override string ToString()
        //{
        //    return
        //        $"Nome: {nome}\n" +
        //        $" Classe: {classe}\n " +
        //        $" lvl: {level}\n " +
        //        $" HP: {hp}\n" +
        //        $" MP: {mp}";
        //}
    }
}
