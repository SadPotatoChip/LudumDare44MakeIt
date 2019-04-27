using System.Collections.Generic;
using PlayerManagement.AfflictionManagement;

namespace PlayerManagement.AnswerEffectManagement {
    public class AnswerEffectGroup {
        public List<string> effects { get; set; }

        public void executeOnPlayer(Player player) {
            if (effects == null || effects.Count == 0) {
                return;
            }
            
            foreach (var effect in effects) {
                var elements = effect.ToLower().Split('|');
                switch (elements.Length) {
                    case 1:
                        var isTrue = false==elements[0].StartsWith("~");
                        player.state.affectState(isTrue?elements[0] : elements[0].Remove(0,1),
                            null,isTrue);
                        break;
                    case 2:
                        player.state.affectState(elements[0],int.Parse(elements[1]));
                        break;
                    case 3:
                        player.afflictions.afflict(new PlayerAffliction(
                            int.Parse(elements[1]),
                            int.Parse(elements[2]),
                             elements[0]
                            ));
                        break;
                }
            }
        }                
    }
}