using System.Collections.Generic;
using PlayerManagement.AfflictionManagement;
using PlayerManagement.States;

namespace PlayerManagement {
    public class Player {
        public CurrentState state;
        public CurrentAfflictions afflictions;

        public static int minStateValue = 0;
        public static int maxStateValue = 100;
        
        public int age = 0;

        public Player() {
            state=new CurrentState();
            afflictions=new CurrentAfflictions();
        }

    }
}