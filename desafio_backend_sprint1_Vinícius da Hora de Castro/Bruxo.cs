using System;
using System.Collections.Generic;
using System.Text;

namespace desafio_backend_sprint1_Vinícius_da_Hora_de_Castro
{
    public class Bruxo : IBruxo
    {
        public string Nome { get; set; }
        public string Casa { get; set; }
        public string Matricula { get; private set; }

        public Bruxo(string nome, string casa)
        {
            Nome = nome;
            Casa = casa;
            Matricula = GerarMatricula();
        }

        public string GerarMatricula()
        {
            Random random = new Random();
            int numeroAleatorio = random.Next(1000, 10000); 
            return $"HOG-{numeroAleatorio}";
        }

        public virtual void LancarFeitico()
        {

            Console.WriteLine($"{Nome} lançou um feitiço!");
            Console.WriteLine(@"
           ＜~ヽ、
          　/　　＼
          ,' ==＝=｀､
        ＜__( ● ᴗ●)_＞ 
          ⊂　　   つ━━✨✨✨ Wingardium Leviosa!
            しーーＪ  ");

        }
    }
}
