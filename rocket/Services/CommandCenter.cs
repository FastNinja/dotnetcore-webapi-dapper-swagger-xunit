using System;
using System.Collections.Generic;
using System.Linq;

namespace rocket.Services
{
    public class CommandCenter
    {
        private readonly IEnumerable<string> _possibleDestinations;
        public CommandCenter(IEnumerable<string> possibleDestinations)
        {
            this._possibleDestinations = possibleDestinations;

        }

        public string Launch(string destination)
        {
            if (!_possibleDestinations.Contains(destination))
            {
                throw new ArgumentException(string.Format("Unknown destination:{0}, available:{1}", destination, string.Join(",", _possibleDestinations)));
            }

            return "Launched";
        }
    }
}