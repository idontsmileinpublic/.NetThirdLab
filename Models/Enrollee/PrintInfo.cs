using System;
using Models.Interfaces;

namespace Models.Enrollee
{
    public class PrintInfo
    {
        public IPresenters Presenters { get; set; } 

        public void Print(int element)
        {
            IEnrollee enrollee = Data.GetEnrollee(element);
            IEnrolleeData info = Presenters.GetPresentation(enrollee);
            Console.WriteLine(info.Present());
        }
    }
}
