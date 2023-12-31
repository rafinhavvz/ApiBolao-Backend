﻿
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Bolao_API_MODEL
{
    [Table("Partidas")]
    public class Partidas
    {
        [Key]
        [Column("ID")]
        [Display(Name = "Codigo")]
        public int ID { get; set; }

        [Column("IDBolao")]
        [Display(Name = "IDBolao")]
        public int IDBolao { get; set; }

        [Column("IDTeamHome")]
        [Display(Name = "IDTeamHome")]
        public int IDTeamHome { get; set; }

        [Column("IDTeamAway")]
        [Display(Name = "IDTeamAway")]
        public int IDTeamAway { get; set; }

        [Column("Round")]
        [Display(Name = "Round")]
        public int Round { get; set; }

        [Column("Data")]
        [Display(Name = "Data")]
        public DateTime Data { get; set; }

        [Column("Resultado")]
        [Display(Name = "Resultado")]
        public int Resultado { get; set; }

        [Column("Status")]
        [Display(Name = "Status")]
        public int Status { get; set; }

    }
}
