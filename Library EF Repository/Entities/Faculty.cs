using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_EF_Repository.Entitys
{
    public class Faculty : BaseEntity
    {
        public string ?Name { get; set; }
        public ICollection<Group> Groups { get; set; }
    }
}
