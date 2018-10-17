namespace ControleDeSeriesFilmes.MODEL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("filmesseries.filmes")]
    public partial class filme
    {
        public int Id { get; set; }

        [StringLength(255)]
        public string Nome { get; set; }

        [StringLength(255)]
        public string Classificacao { get; set; }

        [StringLength(255)]
        public string Diretor { get; set; }

        [StringLength(255)]
        public string Estudio { get; set; }

        public int? Duracao { get; set; }
    }
}
