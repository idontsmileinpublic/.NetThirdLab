using Models.Enrollee;
using Models.Presenters;

namespace Lab3Maistrenko

    /* Реалізувати задачу «Абітурієнти ЗВО» для введення та збереження даних 
     * абітурієнтів. По кожному з абітурієнтів необхідно зберігати наступну 
     * інформацію: прізвище, ім’я, по-батькові, дату на народження, бал ЗНО 
     * по трьом предметам, спеціальності, на які він подає документи. 
     * Необхідно реалізувати виведення та збереження інформації про 
     * абітурієнта в декількох форматах.*/

{
    class Program
    {
        static void Main(string[] args)
        {
            int element = 1;

            PrintInfo printer = new PrintInfo();
            printer.Presenters = new PersonalInfoPresenters();
            printer.Print(element);
            printer.Presenters = new GradesInfoPresenters();
            printer.Print(element);
            printer.Presenters = new PrioritiesPresenters();
            printer.Print(element);
        }
    }
}
