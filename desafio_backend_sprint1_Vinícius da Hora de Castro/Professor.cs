using System;
using System.Collections.Generic;
using System.Text;

namespace desafio_backend_sprint1_Vinícius_da_Hora_de_Castro
{
    public class Professor
    {
        public string Nome { get; set; }
        public string Casa { get; set; }
        public string Disciplinas { get; set; }
        public double Salario { get; set; }
        public void LancarFeitico()
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

        public Professor(string nome, string casa, string disciplinas, double salario)
        {
            Nome = nome;
            Casa = casa;
            Disciplinas = disciplinas;
            Salario = salario;
        }
    }
}
