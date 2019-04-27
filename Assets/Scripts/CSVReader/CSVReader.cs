using System.Collections.Generic;
using System.IO;
using Questions;
using UnityEngine;

namespace CSVReader {
    public static class CSVReader {
        
        public static List<Question> readQuestionsFromFile(string fileName) {
            var filePath = Application.dataPath + "/csv/" + fileName;
            
            var questions = new List<Question>();

            var fs = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            using (var reader = new StreamReader(fs)) {
                reader.ReadLine();
                while (true) {
                    var line = reader.ReadLine();

                    if (string.IsNullOrEmpty(line)) {
                        break;
                    }

                    line = line.ToLower();

                    var q = new Question(line);
                    if (q.isValid) {
                        for (int i = 0; i < q.numberOfAnswers; i++) {
                            // ReSharper disable once PossibleNullReferenceException
                            line = reader.ReadLine().ToLower();
                            var a = new Answer(line);
                            q.answers.Add(a);
                        }

                        questions.Add(q);
                    }
                }
            }

            return questions;
        }
        
    }
}