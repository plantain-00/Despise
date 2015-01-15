using System;

namespace Despise
{
    public class DateTimeGenerator : GeneratorBase<DateTime>
    {
        public override DateTime Generate()
        {
            return Generate(new DateTime(1970, 1, 1), DateTime.Now);
        }

        public override DateTime Generate(DateTime from, DateTime to)
        {
            var totalSeconds = Random.Next((int) (from - new DateTime(1970, 1, 1)).TotalSeconds, (int) (to - new DateTime(1970, 1, 1)).TotalSeconds);
            return new DateTime(1970, 1, 1).AddSeconds(totalSeconds);
        }
    }
}