using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartyPass.UserTypes
{
    class Attendee : User
    {
        String myQRCode;
        public Attendee(String I, Types T, String Q) : base(I, T)
        {
            this.QRCode = Q;
        }
        public String QRCode
        {
            get { return myQRCode; }
            set { myQRCode = value; }
        }
    }
}
