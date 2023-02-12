class Button {
    public bool IsPressed = false;

    public int TimesPressed = 0;

    public Button() {}

    public void Press() {
        IsPressed = (IsPressed == false ? true : false);
        TimesPressed = ++TimesPressed;
    }

    public string Info() {
        var pressed = IsPressed == false ? "Button is not pressed" : "Button is pressed";
        return $"{pressed}.\nPressed {TimesPressed} times.";
    }
}