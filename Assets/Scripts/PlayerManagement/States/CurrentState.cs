using System.Collections.Generic;
using PlayerManagement.AfflictionManagement;

namespace PlayerManagement.States {
    public class CurrentState {
        private Dictionary<string,PlayerState> playerStates;

        public CurrentState() {
            playerStates = new Dictionary<string,PlayerState>();           
        }

        public void affectState(PlayerAffliction affliction) {
            var key = affliction.name.ToLower();
            affectState(affliction.name,affliction.amount);
            affliction.turnsLeft--;
        }
        
        public void affectState(string name, int? amount=null, bool? isTrue=null) {
            var key = name.ToLower();
            if (!playerStates.ContainsKey(key)) {
                initiateState(key,amount,isTrue);
                return;
            }

            if (amount != null) {
                playerStates[key].amount += amount;
            }
            if (isTrue != null) {
                playerStates[key].isTrue = isTrue;
            }
            
        }

        private void initiateState(string name, int? amount=null, bool? isTrue=null) {
            var key = name.ToLower();
            
            amount = (Player.minStateValue + Player.maxStateValue) / 2 + amount;

            if (isTrue == null) {
                isTrue = true;
            }
            playerStates.Add(key,new PlayerState(amount??0,(bool)isTrue,key));
        }
        
        
    }
}