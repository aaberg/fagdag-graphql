using System;
using System.Collections.Generic;

namespace Timereg.Api.Resolvers
{
    public class MemoryTimeRepository : ITimesRepository
    {
        public Dictionary<int, List<Time>> _allTimes;

        public MemoryTimeRepository()
        {
            _allTimes = new Dictionary<int, List<Time>>();
            _allTimes.Add(1, new List<Time>
            {
                new Time{Date = DateTime.Now.AddDays(-2).Date, Description = "Spv", Hours = 7.5m},
                new Time{Date = DateTime.Now.AddDays(-1).Date, Description = "Spv", Hours = 8m},
            });
        }

        public Time AddTime(int employeeId, string description, decimal hours, DateTime date)
        {
            var time = new Time {Date = date, Description = description, Hours = hours};
            if (!_allTimes.ContainsKey(employeeId))
            {
                _allTimes.Add(employeeId, new List<Time>());
            }
            
            _allTimes[employeeId].Add(time);

            return time;
        }

        public Time[] GetTimes(int employeeId)
        {
            return _allTimes.ContainsKey(employeeId) ? _allTimes[employeeId].ToArray() : new Time[0];
        }
    }
}