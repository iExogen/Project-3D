using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;

public class InventoryManager : MonoBehaviour
{
    public InputActionProperty yButton;
    XRBaseInteractable yButtonPress;

    public Transform head;
    public float spawnDistance = 0.5f;

    private bool buttonyValue;
    public GameObject inventory;
    public GameObject playerCamera;
    public bool hasPressedStart;
    bool isInvisible;
    Vector3 startingPosition;
    // Start is called before the first frame update
    void Start()
    {
        startingPosition = inventory.transform.localPosition;
        hasPressedStart = false;

    }

    // Update is called once per frame
    void Update()
    {
        if(!hasPressedStart) return;
        if(Vector3.Distance(inventory.transform.position,head.position)>=2)
        {
            inventory.transform.localPosition = new Vector3(0, -10, 0);
            isInvisible = true;
        }
        if (yButton.action.triggered)
        {
            if(isInvisible)
            {
                inventory.transform.position = head.position + new Vector3(head.forward.x, 0, head.forward.z).normalized;
                isInvisible = false;
            }
            else
            {
                inventory.transform.localPosition = new Vector3(0, -10, 0);
                isInvisible = true;
            }
            inventory.transform.LookAt(new Vector3(head.position.x, inventory.transform.position.y, head.position.z));
            inventory.transform.forward *= -1;
        }
    }
}
