using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CapsuleThatCanBeToggled : MonoBehaviour
{
    // subscribe to the event

    private void OnEnable()
    {
        // Subscribe methods to the event
        ToggleCubeManager.onMessageRecieved += ShoutOutMessage;
    }

    private void OnDisable()
    {
        // Unsubscribe methods from events
        ToggleCubeManager.onMessageRecieved -= ShoutOutMessage;
    }

    private void ShoutOutMessage(string newMessage)
    {
        Debug.Log("WARNNING! " + gameObject.name + " SAYS " + newMessage);
    }

    private void ToggleVisibility()
    {

    }
}
