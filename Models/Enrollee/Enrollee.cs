using System;
using System.Collections.Generic;
using Models.Interfaces;

namespace Models.Enrollee
{
    public class Enrollee : IEnrollee
    {
        public int Id { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Dictionary<string, int?> Grades { get; set; }
        public Dictionary<int, int> Priorities { get; set; }


    }
}
