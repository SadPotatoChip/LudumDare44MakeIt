using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using PlayerManagement.PhaseManagment;
using Questions;
using UnityEngine;

namespace Readers {
    public class JSONReader {

        public static List<Question> readQuestionsFromFile(string fileName) {
            var filePath = Application.dataPath + "/StreamingAssets/json/" + fileName;
            List<Question> questions;
            
            using (StreamReader r = new StreamReader(filePath)){
                string json = r.ReadToEnd();
                questions = JsonConvert.DeserializeObject<List<Question>>(json);
            }            

            return questions;
        }
        
        public static List<Phase> readPhasesFromFile() {
            var filePath = Application.dataPath + "/StreamingAssets/json/_phaseInfo.json";
            List<Phase> phases;
            
            using (StreamReader r = new StreamReader(filePath)){
                string json = r.ReadToEnd();
                phases = JsonConvert.DeserializeObject<List<Phase>>(json);
            }            

            return phases;
        }

    }
}
