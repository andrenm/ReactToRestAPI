using System;
using System.Collections.Generic;

namespace WebApiExample.Persistence.Models
{
    public partial class TbEmployees
    {
        public int IdEmployee { get; set; }
        public string NameFull { get; set; }
        public string ContactNumber { get; set; }
        public string Email { get; set; }
        public string Thumbnail { get; set; }
        public int? IdSector { get; set; }
        public string NameSector { get; set; }

        public virtual TbSectors IdSectorNavigation { get; set; }
    }
}
