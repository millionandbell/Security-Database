using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOfficerDBApp
{
   public class Offenders
    {
        public string firstname, lastname, operatorslicense, notes;
        public int id;
        public Image photo;
        private object notes1;

        public Offenders(int id, string firstname, string lastname, string operatorslicense)
        {
            this.id = id;
            this.firstname = firstname;
            this.lastname = lastname;
            this.operatorslicense = operatorslicense;
        }

        public Offenders(int id, string firstname, string lastname, Image photo, string operatorslicense)
        {
            this.id = id;
            this.firstname = firstname;
            this.lastname = lastname;
            this.photo = photo;
            this.operatorslicense = operatorslicense;
        }

        public Offenders(int id, string firstname, string lastname, string operatorslicense, string notes, Image photo)
        {
            this.id = id;
            this.firstname = firstname;
            this.lastname = lastname;
            this.notes = notes;
            this.photo = photo;
            this.operatorslicense = operatorslicense;
        }

        public Offenders(int id, string firstname, string lastname, string notes, Image photo, string operatorslicense)
        {
            this.id = id;
            this.firstname = firstname;
            this.lastname = lastname;
            this.notes = notes;
            this.photo = photo;
            this.operatorslicense = operatorslicense;
        }

        public Offenders(int id, string firstname, string lastname, object notes1, Image photo, string operatorslicense)
        {
            this.id = id;
            this.firstname = firstname;
            this.lastname = lastname;
            this.notes1 = notes1;
            this.photo = photo;
            this.operatorslicense = operatorslicense;
        }

        public Offenders(int id, string firstname, string lastname, string gender, string notes, Image photo, string operatorslicense)
        {
            this.id = id;
            this.firstname = firstname;
            this.lastname = lastname;
            this.notes = notes;
            this.photo = photo;
            this.operatorslicense = operatorslicense;
        }

        public Offenders(int id, string firstname, string lastname, string dob, string notes, string operatorslicense, Image photo, string operatorslicense1)
        {
            this.id = id;
            this.firstname = firstname;
            this.lastname = lastname;
            this.notes = notes;
            this.operatorslicense = operatorslicense;
            this.photo = photo;
        }

        public Offenders(int id, string firstname, string lastname, string gender, int dob1, string notes, Image photo, string operatorslicense)
        {
            this.id = id;
            this.firstname = firstname;
            this.lastname = lastname;
            this.notes = notes;
            this.photo = photo;
            this.operatorslicense = operatorslicense;
        }
    }
}
