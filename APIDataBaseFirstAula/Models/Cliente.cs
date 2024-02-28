using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace APIDataBaseFirstAula.Models
{
    public partial class Cliente
    {
        [Key]
        [Column("CPF")]
        [StringLength(14)]
        public string Cpf { get; set; } = null!;
        [Column("RG")]
        [StringLength(30)]
        public string Rg { get; set; } = null!;
        [StringLength(200)]
        public string Nome { get; set; } = null!;
        [StringLength(15)]
        public string? Telefone { get; set; }
        [StringLength(15)]
        public string Celular { get; set; } = null!;
        [StringLength(50)]
        public string Logradouro { get; set; } = null!;
        [StringLength(20)]
        public string Numero { get; set; } = null!;
        [StringLength(50)]
        public string? Complemento { get; set; }
        [StringLength(50)]
        public string Cidade { get; set; } = null!;
        [StringLength(2)]
        public string Estado { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime DataInclusao { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataAlteracao { get; set; }
        public bool? Ativo { get; set; }
    }
}
