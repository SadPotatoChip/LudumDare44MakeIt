public abstract class PlayerState {
    public int? value;
    public bool? isTrue;
    private string _name;
    public string name {
        get { return name; }
        set { _name = value.ToLower(); }
    }

    public PlayerState(int? value, string name) {
        this.value = value;
        this.name = name;
    }

    public PlayerState(bool isTrue, string name) {
        this.isTrue = isTrue;
        this.name = name;
    }
}