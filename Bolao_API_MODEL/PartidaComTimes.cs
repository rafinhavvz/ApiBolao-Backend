﻿using Bolao_API_MODEL;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Bolao_API_DAL
{
    public class PartidaComTimes
    {
        public int ID { get; set; }
        public int IDBolao { get; set; }
        public int IDTeamHome { get; set; }
        public int IDTeamAway { get; set; }
        public string TimeHomeName { get; set; }
        public string TimeHomeLogo { get; set; }
        public string TimeAwayName { get; set; }
        public string TimeAwayLogo { get; set; }
        public int Round { get; set; }
        public DateTime Data { get; set; }
        public int Resultado { get; set; }
        public int Status { get; set; }
    }
}