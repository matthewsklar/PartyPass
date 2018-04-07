using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartyPass.UserTypes
{
    /**
     * Represents a User object
     */
    public abstract class User : IUser
    {
        enum types {Bouncer, Bartender, Attendee };
        private String ID = "123456789";
        private 
        
        String getID()
        {
            return ID;
        }
        String getType()
        {
            return type;
        }

    }
}
