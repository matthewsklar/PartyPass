using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartyPass.UserTypes
{
    /**
     * Author Jordan Goldstein
     * Version 1.0
     * Represents a User object
     */
    public class User
    {
        public enum Types { General, Bouncer, Bartender, Attendee };
        private String myID;
        private Types myType;

        public User()
        {
            this.Type = Types.General;
            this.ID = "123456789";
        }
        public User(String I, Types T)
        {
            this.Type = T;
            this.ID = I;
        }
        public String ID
        {
            get { return myID; }
            set { myID = value; }
        }
        public Types Type
        {
            get { return myType; }
            set { myType = value; }
        }
    }
}
