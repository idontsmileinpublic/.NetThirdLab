using System;
using System.Collections.Generic;

namespace Models.Interfaces
{
    public interface IEnrollee
    {
        public int Id { get; }
        public string Surname { get; }
        public string Name { get; }
        public string Patronymic { get; }
        public DateTime DateOfBirth { get; }
        public Dictionary<string, int?> Grades { get; }
        public Dictionary<int, int> Priorities { get; }
    }
}
