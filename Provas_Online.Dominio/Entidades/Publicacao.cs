﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Provas_Online.Dominio.Entidades
{
    public class Publicacao
    {
        public int Id { get; set; }
        public Avaliacao Avaliacao { get; set; }
        public int IdAvaliacao { get; set; }
        public DateTime DataPublicacao { get; set; }
        public DateTime DateInicio { get; set; }
        public DateTime DateFim { get; set; }
        public int ValorProva { get; set; }
        public string Turma { get; set; }
    }
}
