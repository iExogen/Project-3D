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
    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.CompareTag("Door"))
        {
            onDoor = true;
        }
    }
    private void OnCollisionExit(Collision other)
    {
        if (other.gameObject.CompareTag("Door"))
        {
            onDoor = false;
        }
    }
    private void Update()
    {
        //if (itemsEquiped < 3) return;
        if(onDoor && GameManager.Instance.equipedItems==3)
        {
            SceneManager.LoadScene(1);
        }
    }
}
