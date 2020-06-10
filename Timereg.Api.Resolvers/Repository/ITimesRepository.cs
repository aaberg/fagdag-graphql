using System;

namespace Timereg.Api.Resolvers
{
    public interface ITimesRepository
    {
        Time AddTime(int employeeId, string description, decimal hours, DateTime date);

        Time[] GetTimes(int employeeId);
    }
}