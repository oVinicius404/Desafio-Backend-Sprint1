using System;
using System.Collections.Generic;
using System.Text;

namespace desafio_backend_sprint1_Vinícius_da_Hora_de_Castro
{
    public class Professor : Bruxo
    {
        public string Disciplinas { get; set; }
        public double Salario { get; set; }

        public Professor(string nome, string casa, string disciplinas, double salario) : base(nome, casa)
        {
            Nome = nome;
            Casa = casa;
            Disciplinas = disciplinas;
            Salario = salario;
        }
    }
}
