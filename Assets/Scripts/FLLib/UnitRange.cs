using System;

namespace FLLib {
    public class UnitRange<T> where T:IComparable{
        public T max;
        public T min;

        public UnitRange(T min, T max) {
            this.max = max;
            this.min = min;
        }


        public virtual bool contains(T val) {
            return val.CompareTo(min)>=0 && val.CompareTo(max)>=0;
        }
    }
}