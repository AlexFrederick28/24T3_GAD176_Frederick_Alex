using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ToggleCube : MonoBehaviour
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
        Debug.Log(gameObject.name + ": " + newMessage);
    }

    private void ToggleVisibility()
    {

    }
}
