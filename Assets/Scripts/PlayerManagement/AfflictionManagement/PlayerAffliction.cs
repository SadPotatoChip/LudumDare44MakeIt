namespace PlayerManagement.AfflictionManagement {
    public class PlayerAffliction {
        public int amount;
        public int turnsLeft;
        public string name;


        public PlayerAffliction(int amount, int turnsLeft, string name) {
            this.amount = amount;
            this.turnsLeft = turnsLeft;
            this.name = name;
        }
    }
}