﻿using LivrariaControleEmprestimo.DATA.Interfaces;
using LivrariaControleEmprestimo.DATA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivrariaControleEmprestimo.DATA.Repositories
{
    public class RepositoryLivro : RepositoryBase<Livros>, IRepositoryLivro
    {
        public RepositoryLivro(bool SaveChanges = true) : base(SaveChanges)
        {

        }

    }
}
