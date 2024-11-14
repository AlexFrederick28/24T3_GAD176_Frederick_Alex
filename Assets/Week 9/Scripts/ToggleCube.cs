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
        ToggleCubeManager.onVisibilityChanged += ToggleVisibility;
    }

    private void OnDisable()
    {
        // Unsubscribe methods from events
        ToggleCubeManager.onMessageRecieved -= ShoutOutMessage;
        ToggleCubeManager.onVisibilityChanged -= ToggleVisibility;
    }

    private void ShoutOutMessage(string newMessage)
    {
        Debug.Log(gameObject.name + ": " + newMessage);
    }

    private void ToggleVisibility()
    {
        // set this game objects active status to not what it currently is (opposite)
        // toggling on and off

        if (gameObject.GetComponent<MeshRenderer>().enabled == true)
        {
            gameObject.GetComponent<MeshRenderer>().enabled = false;
            gameObject.GetComponent<BoxCollider>().enabled = false;
        }
        else
        {
            gameObject.GetComponent<MeshRenderer>().enabled = true;
            gameObject.GetComponent<BoxCollider>().enabled = true;
        }


        
    }
}
