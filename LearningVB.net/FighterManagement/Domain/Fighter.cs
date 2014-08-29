using System.Collections.Generic;

namespace FighterManagement.Domain
{
    class Fighter
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public IList<Flight> Flights { get; set; }
    }
}
