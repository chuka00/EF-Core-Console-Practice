using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core.DAL.Entities
{
    public class BaseEntity
    {
        public int Id { get; set; }

        public DateTime Created { get; set; } = DateTime.Now;
        public DateTime? Updated { get; set; }

        
        public byte[]? TimeStamp { get; set; }
    }
}
