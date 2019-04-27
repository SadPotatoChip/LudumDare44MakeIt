namespace PlayerManagement.States {
    public class PlayerState {
        public int? amount;
        public bool? isTrue;
        public string name;

        public PlayerState(int amount, bool isTrue, string name) {
            this.amount = amount;
            this.isTrue = isTrue;
            this.name = name;
        }

    }
}