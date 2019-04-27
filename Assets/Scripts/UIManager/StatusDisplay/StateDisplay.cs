using PlayerManagement.States;
using TMPro;
using UnityEngine;

namespace UIManager.StatusDisplay {
    public class StateDisplay :MonoBehaviour {
        public TextMeshProUGUI text;

        public void setText(PlayerState state) {
            if (state.isTrue != null) {
                text.text = (state.isTrue == true ? "" : "not ") + state.name;
            }
        }
    }
}