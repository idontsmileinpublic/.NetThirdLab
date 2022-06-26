using System;
using System.Collections.Generic;
using Models.Interfaces;

namespace Models.Enrollee
{
    public class Data
    {
        public static List<IEnrollee> Enrollees => new List<IEnrollee>
        {
            new Enrollee()
            {
                Id = 1,
                Surname = "Петренко",
                Name = "Іван",
                Patronymic = "Петрович",
                DateOfBirth = new DateTime(2002, 02, 02),
                Grades = new Dictionary<string, int?> {
                    { "Математика", 197 },
                    { "Фізика", 192 },
                    { "Українська мова та література", 186 }
                },
                Priorities = new Dictionary<int, int> {
                    { 1, 123 },
                    { 2, 126 },
                    { 3, 121 },
                    { 4, 124 }
                }
            },

            new Enrollee()
            {
                Id = 2,
                Surname = "Мікулова",
                Name = "Марина",
                Patronymic = "Віталіївна",
                DateOfBirth = new DateTime(2003, 12, 24),
                Grades = new Dictionary<string, int?> {
                    { "Математика", 192 },
                    { "Англійська мова", 199 },
                    { "Українська мова та література", 190 }
                },
                Priorities = new Dictionary<int, int> {
                    { 1, 121 },
                    { 2, 126 },
                    { 3, 123 },
                    { 4, 124 }
                }
            },

            new Enrollee()
            {
                Id = 3,
                Surname = "Набієв",
                Name = "Орхан",
                Patronymic = "Махмуд огли",
                DateOfBirth = new DateTime(2002, 06, 02),
                Grades = new Dictionary<string, int?> {
                    { "Математика", 168 },
                    { "Англійська мова", 179 },
                    { "Українська мова та література", 156 }
                },
                Priorities = new Dictionary<int, int> {
                    { 1, 172 },
                    { 2, 176 },
                    { 3, 173 },
                    { 4, 151 }
                }
            },

            new Enrollee()
            {
                Id = 4,
                Surname = "Петренко",
                Name = "Семен",
                Patronymic = "Віталійович",
                DateOfBirth = new DateTime(2003, 08, 06),
                Grades = new Dictionary<string, int?> {
                    { "Математика", 200 },
                    { "Англійська мова", 200 },
                    { "Українська мова та література", 200 }
                },
                Priorities = new Dictionary<int, int> {
                    { 1, 126 },
                    { 2, 121 },
                    { 3, 123 },
                }
            },

        };

        public static IEnrollee GetEnrollee(int element)
        {
            var result = Data.Enrollees;
                return result[element];
        }
    }
}