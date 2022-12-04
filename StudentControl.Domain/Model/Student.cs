using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentControl.Domain.Model
{
    public enum Status
    {
        studying,
        notstudying
    }
    public class Student
    {
        public Guid id { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string? middle_name { get; set; }
        public Status status { get; set; }
        public short graduate { get; set; }
        public string? snils { get; set; }
        public Login? login { get; set; }
        public Group group { get; set; }
        public List<Order>? orders { get; set; }

    }
}
