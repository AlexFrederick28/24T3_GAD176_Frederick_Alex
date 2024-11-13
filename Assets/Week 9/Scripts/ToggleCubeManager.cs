using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Contains event code that toggles the active state of "ToggleCubes".
/// </summary>
public class ToggleCubeManager : MonoBehaviour
{

    public delegate void MessageHandler(string message);
    // We make this static so that the field is part of the class not the instance
    public static MessageHandler onMessageRecieved;

    private void OnEnable()
    {
        // Subscribe methods to the event
        onMessageRecieved += PrintMessage;
        onMessageRecieved += PrintWarning;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Invoke the message event
            onMessageRecieved?.Invoke("Hello from delegate");
        }
    }

    private void OnDisable()
    {
        // Unsubscribe methods from events
        onMessageRecieved -= PrintMessage;
        onMessageRecieved -= PrintWarning;
    }

    private void PrintMessage(string message)
    {
        Debug.Log("Print message " + message);
    }

    private void PrintWarning(string warningMessage)
    {
        Debug.LogWarning("Warning " + warningMessage);
    }
}
