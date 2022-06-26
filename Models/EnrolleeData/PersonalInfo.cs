using System;
using Models.Interfaces;

namespace Models.EnrolleeData
{
    public class PersonalInfo : IEnrolleeData
    {
        public int Id { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public DateTime DateOfBirth { get; set; }

        public string Present()
        {
            return $"Personal information of {Id}: {Surname} {Name} {Patronymic}, birth {DateOfBirth.ToShortDateString()}";
        }
    }
}
