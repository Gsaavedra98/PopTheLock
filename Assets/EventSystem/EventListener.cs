using UnityEngine;
using UnityEngine.Events;

public class EventListener : MonoBehaviour
{
    public GameEvent gameEvent;
    public UnityEvent Response;

    private void OnEnable() { gameEvent.Register(this); }
    private void OnDisable() { gameEvent.DeRegister(this); }
    public void OnEventRaised(){ Response.Invoke(); }
}
