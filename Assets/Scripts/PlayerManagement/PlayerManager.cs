using UnityEngine;

namespace PlayerManagement {
    public class PlayerManager : MonoBehaviour {
        public static PlayerManager instance;

        public Player player;

        private void Awake() {
            instance = this;
        }
    }
}