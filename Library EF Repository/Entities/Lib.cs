using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_EF_Repository.Entitys
{
    public class Lib : BaseEntity
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }

        public ICollection<S_Card> S_Cards { get; set; }
        public ICollection<T_Card> T_Cards { get; set; }

    }
}
