﻿using System;
using System.IO;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace OOP2.Lab08 {
    [DataContract]
    [Serializable]
    public class Animal {

        [DataMember]
        public string Name;
        [DataMember]
        public uint Age;
        [DataMember]
        public string Description;
        [DataMember]
        public DateTime ReceiptDate;
        [DataMember]
        public bool IsInRedBook;
        [DataMember]
        public string Type;
        [DataMember]
        public string Class;
        [DataMember]
        public string Detachment;
        [DataMember]
        [XmlArray("HabitatsList"), XmlArrayItem(typeof(Habitat), ElementName = "Habitat")]
        public List<Habitat> Habitats;
        [DataMember]
        public Person Bailee;

        public float GetCommonHabitatsArea( ) {
            float result = 0f;
            foreach (var a in Habitats) {
                result += a.Area;
            }
            return result;
        }

        public Animal( ) {
            Bailee = new Person( );
            Habitats = new List<Habitat>( );
        }

    }
}
