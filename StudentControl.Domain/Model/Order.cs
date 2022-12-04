using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentControl.Domain.Model
{
    public enum Name
    {
        Priem,
        group_formation,
        Electives,
        Distribution_by_bases_of_practice,
        Transfer,
        Grants
    }
    public class Order
    {
        public string Id { get; set; }
        public Name name { get; set; }
        public DateTime Date { get; set; }
        public string comment { get; set; }
        public List<Student> students { get; set; }

    }
}
