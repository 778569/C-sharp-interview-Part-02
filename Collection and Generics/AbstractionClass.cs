using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection_and_Generics
{
    public abstract class AbstractionClass<D>
    {
        public abstract string GettableName();
        public void putItam(D value)
        {
            Console.WriteLine("Adding item to : " + GettableName());
        }
    }


    public class UsertableManager : AbstractionClass<UserData>
    {
        public override string GettableName()
        {
            return "USERTable";
        }
    }

    public class UserData
    {
        private string username { get; set; }
        private string emailAddress { get; set; }

        public UserData(string username, string emailAddress)
        {
            this.username = username;
            this.emailAddress = emailAddress;
        }
    }

}
