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

    public delegate void VisibilityHandler();
    public static VisibilityHandler onVisibilityChanged;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Invoke the message event
            //onMessageRecieved?.Invoke("Hello from delegate");

            // Invoke visibility event
            onVisibilityChanged?.Invoke();
        }
    }

   
}
