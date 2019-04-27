using System.Collections.Generic;

namespace PlayerManagement {
    public class Player {
        public Dictionary<string,PlayerState> states;
        public int age = 0;

        public Player() {
            states=new Dictionary<string, PlayerState>();
        }

    }
}