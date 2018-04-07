using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartyPass.UserTypes
{
    /**
     * Interface for all users of the application:
     * Bouncers
     * Bartenders
     * Attendees
     */
    interface IUser
    {
        /*
         * Returns the ID of the User
         */
        String getID();
        /**
         * Returns the type of the User
         */
        String getType();
    }
}
