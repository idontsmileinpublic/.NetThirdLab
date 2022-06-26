using Models.Interfaces;
using System.Collections.Generic;
using System.Text;

namespace Models.EnrolleeData
{
    public class Priorities : IEnrolleeData
    {
        public Dictionary<int, int> Priority { get; set; }

        public int Id { get; set; }

        public string Present()
        {
            var result = new StringBuilder($"{Id}'s priorities:");

            foreach (var item in Priority)
                result.Append($"\n{item.Key}: {item.Value}");

            return result.ToString();
        }
    }
}
