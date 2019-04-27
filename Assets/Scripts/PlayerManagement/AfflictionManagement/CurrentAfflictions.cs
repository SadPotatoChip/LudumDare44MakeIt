using System.Collections.Generic;
using PlayerManagement.States;

namespace PlayerManagement.AfflictionManagement {
    public class CurrentAfflictions {
        private Dictionary<string,PlayerAffliction> playerAfflictions;

        public CurrentAfflictions() {
            playerAfflictions = new Dictionary<string,PlayerAffliction>();           
        }

        public void afflict(PlayerAffliction affliction) {
            var key = affliction.name.ToLower();
            affliction.name = key;
            if (false == playerAfflictions.ContainsKey(key)) {
                playerAfflictions.Add(key,affliction);
            } else {
                playerAfflictions[key].amount += affliction.amount;
                playerAfflictions[key].turnsLeft += affliction.turnsLeft;
            }
        }
    }
}