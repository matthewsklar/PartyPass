using PartyPass.UserTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartyPass.Party {
    class Party {

        public List<Bartender> Bartenders { get; set; }
        public List<Bouncer> Bouncers { get; set; }

        public Party(List<Bartender> bartenders, List<Bouncer> bouncers) {
            Bartenders = bartenders;
            Bouncers = bouncers;
            if (Bartenders == null) Bartenders = new List<Bartender>();
            if (Bouncers == null) Bouncers = new List<Bouncer>();
        }


    }
}
