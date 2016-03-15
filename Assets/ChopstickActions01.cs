using InControl;

public class ChopstickActions01 : PlayerActionSet {
    public PlayerAction LStickLeft;
    public PlayerAction LStickRight;
    public PlayerAction LStickUp;
    public PlayerAction LStickDown;
    public PlayerTwoAxisAction LStickMove;
    public PlayerAction LStickRotateLeft;
    public PlayerAction LStickRotateRight;
    public PlayerOneAxisAction LStickRotate;

    public PlayerAction RStickLeft;
    public PlayerAction RStickRight;
    public PlayerAction RStickUp;
    public PlayerAction RStickDown;
    public PlayerTwoAxisAction RStickMove;
    public PlayerAction RStickRotateLeft;
    public PlayerAction RStickRotateRight;
    public PlayerOneAxisAction RStickRotate;

    public ChopstickActions01()
    {
        LStickLeft = CreatePlayerAction("Move LStick Left");
        LStickRight = CreatePlayerAction("Move LStick Right");
        LStickUp = CreatePlayerAction("Move LStick Up");
        LStickDown = CreatePlayerAction("Move LStick Down");
        LStickMove = CreateTwoAxisPlayerAction(LStickLeft, LStickRight, LStickDown, LStickUp);
        LStickRotateLeft = CreatePlayerAction("Rotate LStick Left");
        LStickRotateRight = CreatePlayerAction("Rotate LStick Rigth");
        LStickRotate = CreateOneAxisPlayerAction(LStickRotateLeft, LStickRotateRight);

        RStickLeft = CreatePlayerAction("Move RStick Left");
        RStickRight = CreatePlayerAction("Move RStick Right");
        RStickUp = CreatePlayerAction("Move RStick Up");
        RStickDown = CreatePlayerAction("Move RStick Down");
        RStickMove = CreateTwoAxisPlayerAction(RStickLeft, RStickRight, RStickDown, RStickUp);
        RStickRotateLeft = CreatePlayerAction("Rotate RStick Left");
        RStickRotateRight = CreatePlayerAction("Rotate RStick Rigth");
        RStickRotate = CreateOneAxisPlayerAction(RStickRotateLeft, RStickRotateRight);
    }
}
