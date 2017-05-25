using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace OOP2.Lab08 {
    [Serializable]
    [DataContract]
    public class Habitat {

        [DataMember]
        public float Azimuth = 0;
        [DataMember]
        public float Zenith = 0;
        [DataMember]
        public float Area = 0;

        public Habitat(float az = 0f, float zen = 0f, float area = 0f) {
            this.Azimuth = az;
            this.Zenith = zen;
            this.Area = area;
        }

        public Habitat( ) {
        }

        public override String ToString( ) {
            return Azimuth + " : " + Zenith + " = " + Area + " км2";
        }

    }
}
