using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core.DAL.Entities
{
    public class Tag : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public IEnumerable<TheTask> Tasks { get; set; } = new List<TheTask>();
    }
}
