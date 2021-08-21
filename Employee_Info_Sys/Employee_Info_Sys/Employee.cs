using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Info_Sys
{
    class Employee : Department
    {
        private byte _id;
        private string _name = "N/A";
        private string _surName = "N/A";
        private byte _age = 0;
        private int _phoneNumber = 0;

        internal byte id
        {
            get => this._id;
            set => this._id = value;
        }
        internal string name
        {
            get => this._name;
            set => this._name = value;
        }
        internal string surName
        {
            get => this._surName;
            set => this._surName = value;
        }
        internal int phoneNumber
        {
            get => this._phoneNumber;
            set => this._phoneNumber = value;
        }
        internal byte age
        {
            get => this._age;
            set => this._age = value;
        }

    }
}
