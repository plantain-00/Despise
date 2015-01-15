using System;

namespace Despise
{
    public class DateTimeGenerator : GeneratorBase<DateTime>
    {
        public override DateTime Generate()
        {
            var totalSeconds = Random.Next(0, (int) (DateTime.Now - new DateTime(1970, 1, 1)).TotalSeconds);
            return new DateTime(1970, 1, 1).AddSeconds(totalSeconds);
        }
    }
}