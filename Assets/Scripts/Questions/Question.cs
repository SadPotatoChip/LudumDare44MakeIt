using System;
using System.Collections.Generic;
using System.Linq;
using FLLib;
using PlayerManagement;
using Questions.Conditions;

namespace Questions {
    public class Question {
        public readonly bool isValid = true;

        public readonly IntRange possibleAge;
        public readonly string title;
        public readonly string text;
        public readonly List<Answer> answers;
        public readonly ConditionGroup conditions;

        public readonly int numberOfAnswers;

        public Question(string line) {
            try {
                var values = line.TrimEnd().Split(',').Where(val => false == string.IsNullOrEmpty(val)).ToList();
                if (values.Count < 5) {
                    throw new Exception("incorrect format of question");
                }

                numberOfAnswers = int.Parse(values[0]);
                title = values[1];
                text = values[2];
                possibleAge = new IntRange(int.Parse(values[3]), int.Parse(values[4]));

                conditions = values.Count > 5 ? new ConditionGroup(values[5]) : new ConditionGroup();

                answers = new List<Answer>();
            } catch (Exception) {
                isValid = false;
            }
        }

        public bool isViable() {
            return possibleAge.contains(PlayerManager.instance.player.age);
            //TODO condition checks
        }

        public override string ToString() {
            var s = "";
            s += "<b>Title: " + title +"</b>\n";
            s += "Text: " + text +"\n";
            s += "PossibleAge: " + possibleAge.min + "->" + possibleAge.max +"\n";
            s += "Answers: \n";
            for (var i = 0; i < answers.Count; i++) {
                s += i + ") " + answers[i].ToString();
            }
            s += "Conditions: ";
            s += conditions.ToString();

            return s;
        }
    }
}