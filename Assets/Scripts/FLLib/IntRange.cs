using UnityEngine;

namespace FLLib {
    public class IntRange : UnitRange<int> {

        public IntRange(int min, int max) : base(min,max) {

        }

        public override bool contains(int val) {
            return val>=min && val<=max;
        }

        public int randomValue() {
            return Random.Range(min, max + 1);
        }
    }
}