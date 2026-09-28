using System;
using System.Collections.Generic;
using System.Text;

namespace desafio_backend_sprint1_Vinícius_da_Hora_de_Castro
{
    public class Bruxo : IBruxo
    {
        public string Nome { get; set; }
        public string Casa { get; set; }
        public virtual void LancarFeitico()
        {

            Console.WriteLine($"O(a) professor(a) {Nome} lançou um feitiço!");
            Console.WriteLine(@"
           ＜~ヽ、
          　/　　＼
          ,' ==＝=｀､
        ＜__( ● ᴗ●)_＞ 
          ⊂　　   つ━━✨✨✨ Wingardium Leviosa!
            しーーＪ  ");

        }

        public Bruxo(string nome, string casa)
        {
            Nome = nome;
            Casa = casa;
        }


    }
}
