﻿using Provas_Online.Dominio.Entidades.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Provas_Online.Dominio.Entidades
{
    public class Avaliacao : EntidadeBase
    {
        public string Disciplina { get; set; }
        public string Materia { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public Professor Professor { get; set; }
        public int IdProfessor { get; set; }
        public List<Questao> Questoes { get; set; }
    }
}
