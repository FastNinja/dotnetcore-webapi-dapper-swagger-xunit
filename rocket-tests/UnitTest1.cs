using System;
using Xunit;
using rocket.Services;
using System.Collections.Generic;
using System.Linq;

namespace rocket_tests
{
    public class UnitTest1
    {
        [Fact]
        public void Fails_WhenLaunch_IntoUnknownDestination()
        {
            var commandCenter = new CommandCenter(new List<string>() { "Moon", "Jupiter" });
            Assert.Throws<ArgumentException>(() => commandCenter.Launch("Mars"));
        }

        [Fact]
        public void Launches_whendestination_IsKnown()
        {
            var commandCenter = new CommandCenter(new List<string>() { "Moon", "Jupiter" });
            commandCenter.Launch("Moon");
        }


        [Fact]
        public void ReadsPostgress_Repository()
        {
            var repo = new Repository();
            var actualLandings = repo.GetLandings();
        }
    }
}
