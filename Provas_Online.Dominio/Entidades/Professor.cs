﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Provas_Online.Dominio.Entidades
{
    public class Professor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public string Email { get; set; }
    }
}
