using Questions;
using TMPro;
using UnityEngine;

namespace UIManager.QuestionAnswerUI {
    public class QAManager : MonoBehaviour {
        public TextMeshProUGUI titleText;
        public TextMeshProUGUI questionText;

        public Transform answerParent;
        public GameObject answerPrefab;

        public void displayQuestion(Question question) {
            titleText.text = question.title;
            questionText.text = question.text;
            foreach (var answer in question.answers) {
                Instantiate(answerPrefab, answerParent);
                var answerManager = answerPrefab.GetComponent<AnswerManager>();
                answerManager.answer = answer;
            }
        }
    }
}