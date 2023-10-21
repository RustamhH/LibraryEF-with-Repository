using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_EF_Repository.Entitys
{
    public class Department : BaseEntity
    {
        public string ?Name { get; set; }
        public ICollection<Teacher> Teachers { get; set; }
    }
}
