using System.Linq;
using PlayerManagement.PhaseManagment;
using Readers;
using UIManager.QuestionAnswerUI;
using UnityEngine;

namespace PlayerManagement {
    public class PlayerManager : MonoBehaviour {
        public static PlayerManager instance;

        public Player player;
        public PhaseManager phaseManager;
        private void Awake() {
            instance = this;
        }

        public void startGame() {
            player=new Player();
            phaseManager = new PhaseManager {phases = JSONReader.readPhasesFromFile()};
            QAManager.instance.loadPhase(phaseManager.phases.First());
        }
    }
}