using BLL.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models
{
    public class StudentModel
    {
        public Student Record{get;set;}
        //public string Name{get;set;}
        //public string Surname { get;set;}
        //public DateTime BirthDate {  get;set;}
        //public decimal GPA { get;set;}

        public string Name => Record.Name;
        public string Surname => Record.Surname;
        public DateTime? BirthDate => Record.BirthDate;
        public decimal? GPA => Record.Gpa;
    }
}
