using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using UnityEngine.XR.Interaction.Toolkit;

public class StartGame : MonoBehaviour
{
    public GameObject door;
    private void Update()
    {
        //if (itemsEquiped < 3) return;
        if(door.activeSelf == false && GameManager.Instance.equipedItems)
        {
            SceneManager.LoadScene(1);
        }
            door.SetActive(true);
    }
}
