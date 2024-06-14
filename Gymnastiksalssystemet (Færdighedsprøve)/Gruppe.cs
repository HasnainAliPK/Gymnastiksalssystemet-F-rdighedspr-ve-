using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gymnastiksalssystemet__Færdighedsprøve_
{
    internal class Gruppe
    {
        public string Name { get; set; }
        public string AgeGroup { get; set; }
        public int NumberOfParticipants { get; set; }
        public int ID { get; set; }

        

        public Gruppe(string Name,string AgeGroup, int NumberOfParticipants, int ID)
        {
            this.Name = Name;
            this.AgeGroup = AgeGroup;
            this.NumberOfParticipants = NumberOfParticipants;
            this.ID = ID;

        }

        public override string ToString()
        {
            return $"Name: {Name}, AgeGroup: {AgeGroup}, NumberOfParticipants: {NumberOfParticipants}, Id: {ID}";
        }

    }
}
