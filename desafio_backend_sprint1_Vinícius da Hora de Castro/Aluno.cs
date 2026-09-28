using System;
using System.Collections.Generic;
using System.Text;

namespace desafio_backend_sprint1_Vinícius_da_Hora_de_Castro
{
    public class Aluno : Bruxo
    {
        public List<double> Notas { get; set; } = new List<double>();
        public double Media { get; set; }

        public override void LancarFeitico()
        {
            Console.WriteLine($"O(a) aluno(a) {Nome} falhou em lançar um feitiço!");
            Console.WriteLine(@"
            ＜~ヽ、
          　/　　＼
          ,' ==＝=｀､
        ＜__( ಥ︿ಥ)_＞ 
          ⊂　　   つ━━💨...
            しーーＪ  ");
        }
        public Aluno(string nome, string casa, List<double> notas) : base(nome, casa)
        {
            Nome = nome;
            Casa = casa;
            Notas = notas;
            Media = notas.Count > 0 ? notas.Average() : 0;
        }
    }
}
