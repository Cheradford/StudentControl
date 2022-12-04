using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentControl.Domain.Model
{
    public enum Formofstudy
    {
        full_time,
        part_time
    }
    public class Group
    {
        public Guid Id { get; set; }

        public string Name { get; set; }
        public int NumberOfPeople { get; set; }
        public Formofstudy formofstudy { get; set; }
        public string StudyProfile { get; set; }
        public List<Student> students { get; set; }
    }
}
