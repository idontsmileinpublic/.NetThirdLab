using Models.Interfaces;
using Models.EnrolleeData;

namespace Models.Presenters
{
    public class GradesInfoPresenters : IPresenters
    {
        public IEnrolleeData GetPresentation(IEnrollee enrollee)
        {
            return new GradesInfo {
                Id = enrollee.Id,
                Grades = enrollee.Grades
            };
        }
    }
}
