using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using Questions;
using UnityEngine;

namespace Readers {
    public class JSONReader {

        public static List<Question> readQuestionsFromFile(string fileName) {
            var filePath = Application.dataPath + "/json/" + fileName;
            List<Question> questions;
            
            using (StreamReader r = new StreamReader(filePath)){
                string json = r.ReadToEnd();
                questions = JsonConvert.DeserializeObject<List<Question>>(json);
            }            

            return questions;
        }

    }
}
