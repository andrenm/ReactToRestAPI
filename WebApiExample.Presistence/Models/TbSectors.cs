using System;
using System.Collections.Generic;

namespace WebApiExample.Persistence.Models
{
    public partial class TbSectors
    {
        public TbSectors()
        {
            TbEmployees = new HashSet<TbEmployees>();
        }

        public int IdSector { get; set; }
        public string NameSector { get; set; }

        public virtual ICollection<TbEmployees> TbEmployees { get; set; }
    }
}
