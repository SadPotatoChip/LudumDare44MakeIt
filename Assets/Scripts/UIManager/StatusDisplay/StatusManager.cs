using System.Collections.Generic;
using PlayerManagement;
using TMPro;
using UnityEngine;

namespace UIManager.StatusDisplay {
    public class StatusManager : MonoBehaviour {
        public static StatusManager instance;

        public TextMeshProUGUI ageDisplay;
        public Transform statusParent;
        public GameObject statusPrefab;
        private List<GameObject> statuses;
        
        private void Awake() {
            instance = this;
            statuses=new List<GameObject>();
        }

        public void refresh(Player player) {
            ageDisplay.text = "Age: " + player.age / 12 + "y " + player.age % 12 + "m";
            foreach (var obj in statuses) {
                Destroy(obj);
            }
            foreach (var state in player.state.getStates()) {
                var statusObj = Instantiate(statusPrefab, statusParent);
                statusObj.GetComponent<StateDisplay>().setText(state);
                statuses.Add(statusObj);
            }
        }
               
    }
}