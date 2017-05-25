using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace OOP2.Lab08 {
    [DataContract]
    public class Person {

        [DataMember]
        public string FirstName;
        [DataMember]
        public string LastName;

        public Person(string firstName, string lastName) {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public override String ToString( ) {
            return LastName + " " + FirstName;
        }

    }
}
