using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Info_Sys
{
    class Department
    {
        private string _depName;
        private int _employeeCount=0;

        internal string depName
        {
            get => this._depName;
            set => this._depName = value;
        }

        internal int employeeCount
        {
            get => this._employeeCount;
            set => this._employeeCount = value;
        }
    }
}
