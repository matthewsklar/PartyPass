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
    public abstract class User
    {
        public enum Types { General, Bouncer, Bartender, Attendee };
        private String ID = "123456789";
        private Types type = Types.General;
        private String QRCode;
        /**
         * Returns the ID of the User
         */
        public String GetID()
        {
            return ID;
        }
        /**
         * Returns the type of the User
         */
        public Types GetUserType()
        {
            return type;
        }
        /**
         * Return the QR Code
         */
         public String getQRCode()
        {
            return QRCode;
        }

        public abstract void SetType();
        public abstract void SetQRCode();

    }
}
