using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_EF_Repository.Entitys
{
    public class Press : BaseEntity
    {
        public string? Name { get; set; }
        public ICollection<Book> Books { get; set; }

    }
}
