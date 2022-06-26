using System;
using System.Collections.Generic;
using System.Text;
using Models.Interfaces;

namespace Models.EnrolleeData
{
    public class GradesInfo : IEnrolleeData
    {
        public int Id { get; set; }
        public Dictionary<string, int?> Grades { get; set; }

        public string Present()
        {
            var result = new StringBuilder($"{Id}'s grades:");

            foreach (var item in Grades)
            {
                result.Append($"\n{item.Key}: {item.Value}");
            }

            return result.ToString();
        }
    }
}
