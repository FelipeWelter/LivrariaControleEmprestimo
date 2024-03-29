﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LivrariaControleEmprestimo.DATA.Models
{
    [Table("Livro_Cliente_Emprestimo")]
    public partial class LivroClienteEmprestimo
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("idLivro")]
        public int? IdLivro { get; set; }
        [Column("idCliente")]
        public int? IdCliente { get; set; }
        [Column("dataEmprestimo", TypeName = "datetime")]
        public DateTime? DataEmprestimo { get; set; }
        [Column("dataDevolucao", TypeName = "datetime")]
        public DateTime? DataDevolucao { get; set; }

        [ForeignKey("IdCliente")]
        [InverseProperty("LivroClienteEmprestimo")]
        public virtual Cliente IdClienteNavigation { get; set; }
        [ForeignKey("IdLivro")]
        [InverseProperty("LivroClienteEmprestimo")]
        public virtual Livros IdLivroNavigation { get; set; }
    }
}