using Models.Interfaces;
using Models.EnrolleeData;

namespace Models.Presenters
{
    public class PersonalInfoPresenters : IPresenters
    {
        public IEnrolleeData GetPresentation(IEnrollee enrollee)
        {
            return new PersonalInfo
            {
                Id = enrollee.Id,
                Surname = enrollee.Surname,
                Name = enrollee.Name,
                Patronymic = enrollee.Patronymic,
                DateOfBirth = enrollee.DateOfBirth
            };
        }
    }
}
