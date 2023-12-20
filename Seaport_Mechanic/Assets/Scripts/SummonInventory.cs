using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit.Inputs;
using UnityEngine.XR.Interaction.Toolkit.UI.BodyUI;

public class SummonInventory : MonoBehaviour
{
    public GameObject hammerSocket;
    public GameObject powerSocket;
    public GameObject cutterSocket;
    public GameObject torchSocket;
    public GameObject wrenchSocket;
    public GameObject parentSocket;

    public GameObject hammer;
    public GameObject powertool;
    public GameObject cutter;
    public GameObject torch;
    public GameObject wrench;
    public GameObject emptySlot;

    private Vector3 hammerStartpos;
    private Vector3 powerStartpos;
    private Vector3 cutterStartPos;
    private Vector3 torchStartPos;
    private Vector3 wrenchStartPos;

    public GameObject mainCamera;
    public GameObject spawnSpot;
    [SerializeField]private GameObject currentSlot = null;

    public GameObject torchFlame;
    public GameObject mask;
    public InputActionProperty leftActivate;
    public InputActionProperty rightActivate;
    // Start is called before the first frame update
    void Start()
    {
        hammerStartpos = hammerSocket.transform.position;
        powerStartpos= powerSocket.transform.position;
        cutterStartPos = cutterSocket.transform.position;
        torchStartPos = torchSocket.transform.position;
        wrenchStartPos = wrenchSocket.transform.position;
        currentSlot = emptySlot;
    }

    private void OnCollisionEnter(Collision collision)
    {
        //check if object is a handbutton
        if (collision.gameObject.layer != 11) return;
        SwitchSlot();
        //moving new slot
        MoveItems(collision);
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Welder"))
        {
            if(currentSlot == torchSocket)
            {
                mask.SetActive(true);
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("Welder"))
        {
            if(currentSlot != torchSocket)
            mask.SetActive(false);
        }
    }

    private void Update()
    {
        //make sure items return to slot when too far away
        ReturnItems();
        if (currentSlot == torchSocket && rightActivate.action.ReadValue<float>() > 0.1f)
        {
            torchFlame.SetActive(true);
        }
        else if(currentSlot == torchSocket && leftActivate.action.ReadValue<float>()>0.1f)
        {
            torchFlame.SetActive(true);
        }
        else
        {
            torchFlame.SetActive(false);
        }
    }


    private void SwitchSlot()
    {
        currentSlot.transform.SetParent(parentSocket.transform);
        currentSlot.transform.rotation = Quaternion.Euler(0, 0, 0);
        //moving previous slot
        if (currentSlot == hammerSocket)
        {
            currentSlot.transform.position = hammerStartpos;
            if (Vector3.Distance(hammer.transform.position, currentSlot.transform.position) > 2f)
            {
                hammer.transform.position = hammerStartpos + new Vector3(0, 2, 0);
            }
        }
        else if (currentSlot == powerSocket)
        {
            currentSlot.transform.position = powerStartpos;
            if (Vector3.Distance(powertool.transform.position, currentSlot.transform.position) > 2f)
            {
                powertool.transform.position = powerStartpos + new Vector3(0, 2, 0);
            }
        }
        else if (currentSlot == cutterSocket)
        {
            currentSlot.transform.position = cutterStartPos;
            if (Vector3.Distance(cutterSocket.transform.position, currentSlot.transform.position) > 2f)
            {
                cutter.transform.position = cutterStartPos + new Vector3(0, 2, 0);
            }
        }
        else if (currentSlot == torchSocket)
        {
            currentSlot.transform.position = torchStartPos;
            if (Vector3.Distance(torch.transform.position, currentSlot.transform.position) > 2f)
            {
                torch.transform.position = torchStartPos + new Vector3(0, 2, 0);
            }
        }
        else if (currentSlot == wrenchSocket)
        {
            currentSlot.transform.position = wrenchStartPos;
            if (Vector3.Distance(wrench.transform.position, currentSlot.transform.position) > 2f)
            {
                wrench.transform.position = wrenchStartPos + new Vector3(0, 1, 0);
            }
        }
    }

    private void MoveItems(Collision collision)
    {
        switch (collision.GetContact(0).thisCollider.name)
        {
            case "HammerButton":
                currentSlot = hammerSocket;
                break;
            case "PowerToolButton":
                currentSlot = powerSocket;
                break;
            case "CutterButton":
                currentSlot = cutterSocket;
                break;
            case "TorchButton":
                currentSlot = torchSocket;
                break;
            case "WrenchButton":
                currentSlot = wrenchSocket;
                break;
            default:
                break;
        }
        currentSlot.transform.position = spawnSpot.transform.position;
        currentSlot.transform.rotation = spawnSpot.transform.rotation;
        currentSlot.transform.SetParent(spawnSpot.transform);
    }

    private void ReturnItems()
    {
        //make sure items return to slot when too far away
        if (currentSlot == hammerSocket)
        {
            if (Vector3.Distance(hammer.transform.position, mainCamera.transform.position) > 2f)
            {
                hammer.transform.position = hammerSocket.transform.position + new Vector3(0, .3f, 0);
            }
        }
        else if (currentSlot == powerSocket)
        {
            if (Vector3.Distance(powertool.transform.position, mainCamera.transform.position) > 2f)
            {
                powertool.transform.position = powerSocket.transform.position + new Vector3(0, .3f, 0);
            }
        }
        else if (currentSlot == cutterSocket)
        {
            if (Vector3.Distance(cutter.transform.position, mainCamera.transform.position) > 2f)
            {
                cutter.transform.position = cutterSocket.transform.position + new Vector3(0, .3f, 0);
            }
        }
        else if (currentSlot == torchSocket)
        {
            if (Vector3.Distance(torch.transform.position, mainCamera.transform.position) > 2f)
            {
                torch.transform.position = torchSocket.transform.position + new Vector3(0, .3f, 0);
            }
        }
        else if (currentSlot == wrenchSocket)
        {
            if (Vector3.Distance(wrench.transform.position, mainCamera.transform.position) > 2f)
            {
                wrench.transform.position = wrenchSocket.transform.position + new Vector3(0, .3f, 0);
            }
        }
    }
}
