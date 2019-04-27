public abstract class PlayerState {
    public int? value;
    public bool? isTrue;
    public string name;

    public PlayerState(int? value, string name) {
        this.value = value;
        this.name = name;
    }

    public PlayerState(bool isTrue, string name) {
        this.isTrue = isTrue;
        this.name = name;
    }
}