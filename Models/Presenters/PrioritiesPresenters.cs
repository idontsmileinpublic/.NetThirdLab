using Models.Interfaces;
using Models.EnrolleeData;

namespace Models.Presenters
{
    public class PrioritiesPresenters : IPresenters
    {
        public IEnrolleeData GetPresentation(IEnrollee enrollee)
        {
            return new Priorities
            {
                Id = enrollee.Id,
                Priority = enrollee.Priorities
            };
        }
    }
}
