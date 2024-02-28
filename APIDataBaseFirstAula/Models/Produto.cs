using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace APIDataBaseFirstAula.Models
{
    [Index("Codigo", Name = "UQ__Produtos__06370DACDCFC1A83", IsUnique = true)]
    public partial class Produto
    {
        [Key]
        public int Id { get; set; }
        [StringLength(14)]
        public string Codigo { get; set; } = null!;
        [StringLength(100)]
        public string Descricacao { get; set; } = null!;
        [Column(TypeName = "decimal(16, 2)")]
        public decimal ValorUnitario { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime DataInclusao { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataAlteracao { get; set; }
        public bool? Ativo { get; set; }
    }
}
