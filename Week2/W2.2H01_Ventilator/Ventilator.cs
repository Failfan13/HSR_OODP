class Ventilator
{
    public int Speed;
    public List<Button> Buttons;

    public Ventilator() => Buttons = new List<Button>()
        { new Button(), new Button(), new Button(), new Button() };

    public void PressButton(int number)
    {
        for (int i = 0; i < Buttons.Count; i++)
        {
            try {
                Buttons[number].IsPressed = number != i || number == 0;
                Speed = Buttons.IndexOf(Buttons[number]);
            } catch (Exception) {
                return;
            }
            
        }
    }
    public string Blow() => Speed switch
    {
        <= 0 => "Off",
           1 => "~~~",
           2 => "≈≈≈",
        >= 3 => "===",
    };
}