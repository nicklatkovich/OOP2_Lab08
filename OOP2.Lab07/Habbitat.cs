using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace OOP2.Lab07 {
    [DataContract]
    public class Habitat {

        [DataMember]
        public float Azimuth;
        [DataMember]
        public float Zenith;
        [DataMember]
        public float Area;

        public Habitat(float az = 0f, float zen = 0f, float area = 0f) {
            this.Azimuth = az;
            this.Zenith = zen;
            this.Area = area;
        }

        public override String ToString( ) {
            return Azimuth + " : " + Zenith + " = " + Area + " км2";
        }

    }
}
