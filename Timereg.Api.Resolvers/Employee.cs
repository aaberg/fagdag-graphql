using HotChocolate;

namespace Timereg.Api.Resolvers
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }

        public Time[] Times([Service] ITimesRepository timesRepository)
        {
            return timesRepository.GetTimes(this.Id);
        }
    }
}