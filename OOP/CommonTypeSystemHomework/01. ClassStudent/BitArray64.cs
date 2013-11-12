// 5. Define a class BitArray64 to hold 64 bit values inside an ulong value. 
// Implement IEnumerable<int> and Equals(…), GetHashCode(), [], == and !=.

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ClassStudent
{
    class BitArray64
    {
        private ulong member;

        public ulong Member 
        {
            get { return this.member; }
            set { this.member = value; } 
        }

        public override bool Equals(object obj)
        {
            BitArray64 compared = obj as BitArray64;
            if (this.member == compared.member)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode()
        {
            return (int)member;
        }

        public static bool operator ==(BitArray64 firstValue, BitArray64 secondValue)
        {
            if (firstValue.member == secondValue.member)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(BitArray64 firstValue, BitArray64 secondValue)
        {
            if (firstValue.member == secondValue.member)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}