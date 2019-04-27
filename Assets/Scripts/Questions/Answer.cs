using System;
using FLLib;

namespace Questions {
    public class Answer {
        public readonly string text;
        public readonly int cost;
        
        public Answer(string line) {
            var values = line.TrimEnd().Split(',');
            if (values.Length < 4) {
                throw new Exception("incorrect format of answer");
            }
            text=values[1];
            cost=new IntRange(int.Parse(values[2]),int.Parse(values[3])).randomValue();
        }
        
        public override string ToString() {
            var s = "";
            s += "\n Text: " + text;
            s += "\n Cost: " + cost +"\n";
            return s;
        }
    }
}