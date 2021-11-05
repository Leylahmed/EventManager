using DynamicBox.EventManagement;

public class PlayerIsInsideEvent : GameEvent
{
    public bool IsPlayerInside;

    public PlayerIsInsideEvent (bool isPlayerInside)
    {
        IsPlayerInside = isPlayerInside;
    }
}