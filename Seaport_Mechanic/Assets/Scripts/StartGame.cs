using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using UnityEngine.XR.Interaction.Toolkit;

public class StartGame : MonoBehaviour
{
    private bool onDoor = false;
    public InputActionProperty leftSelect;
    public InputActionProperty rightSelect;
    int itemsEquiped;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Door"))
        {
            onDoor = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Door"))
        {
            onDoor = false;
        }
    }
    private void Update()
    {
        if (itemsEquiped < 3) return;
        if(onDoor && leftSelect.action.ReadValue<float>() > 0.1f)
        {
            SceneManager.LoadScene(1);
        }
        else if (onDoor && rightSelect.action.ReadValue<float>() > 0.1f)
        {
            SceneManager.LoadScene(1);
        }
    }
}
