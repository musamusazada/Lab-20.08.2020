using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class Milk : Product
    {
        private int _volume;
        private float _FatRate;

        public int volume
        {
            get => this._volume;
            set => this._volume = value;
        }

        public float FatRate
        {
            get => this._FatRate;
            set => this._FatRate = value;
        }
    }
}
