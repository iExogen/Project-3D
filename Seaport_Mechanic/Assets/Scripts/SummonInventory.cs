using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.UI.BodyUI;

public class SummonInventory : MonoBehaviour
{
    public GameObject hammerSocket;
    public GameObject powerSocket;
    public GameObject cutterSocket;
    public GameObject torchSocket;
    public GameObject wrenchSocket;
    public GameObject parentSocket;

    private Vector3 hammerStartpos;
    private Vector3 powerStartpos;
    private Vector3 cutterStartPos;
    private Vector3 torchStartPos;
    private Vector3 wrenchStartPos;

    private GameObject currentSlot = null;
    // Start is called before the first frame update
    void Start()
    {
        hammerStartpos = hammerSocket.transform.position;
        powerStartpos= powerSocket.transform.position;
        cutterStartPos = cutterSocket.transform.position;
        torchStartPos = torchSocket.transform.position;
        wrenchStartPos = wrenchSocket.transform.position;
        currentSlot = hammerSocket;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.layer != 11) return;
        currentSlot.transform.SetParent(parentSocket.transform);
        currentSlot.transform.rotation = Quaternion.Euler(0, 0, 0);
        if(currentSlot == hammerSocket)
        {
            currentSlot.transform.position = hammerStartpos;
        }
        else if(currentSlot == powerSocket)
        {
            currentSlot.transform.position = powerStartpos;
        }
        else if(currentSlot == cutterSocket)
        {
            currentSlot.transform.position = cutterStartPos;
        }
        else if (currentSlot == torchSocket)
        {
            currentSlot.transform.position = torchStartPos;
        }
        else if (currentSlot == wrenchSocket)
        {
            currentSlot.transform.position = wrenchStartPos;
        }
        switch (collision.GetContact(0).thisCollider.name)
        {
            case "HammerButton":
                currentSlot = hammerSocket;
                hammerSocket.transform.position = this.gameObject.transform.position;
                hammerSocket.transform.rotation = this.gameObject.transform.rotation;
                hammerSocket.transform.SetParent(this.gameObject.transform);
                break;
            case "PowerToolButton":
                currentSlot = powerSocket;
                powerSocket.transform.position = this.gameObject.transform.position;
                powerSocket.transform.rotation = this.gameObject.transform.rotation;
                powerSocket.transform.SetParent(this.gameObject.transform);
                break;
            case "CutterButton":
                currentSlot = cutterSocket;
                cutterSocket.transform.position = this.gameObject.transform.position;
                cutterSocket.transform.rotation = this.gameObject.transform.rotation;
                cutterSocket.transform.SetParent(this.gameObject.transform);
                break;
            case "TorchButton":
                currentSlot = torchSocket;
                torchSocket.transform.position = this.gameObject.transform.position;
                torchSocket.transform.rotation = this.gameObject.transform.rotation;
                torchSocket.transform.SetParent(this.gameObject.transform);
                break;
            case "WrenchButton":
                currentSlot = wrenchSocket;
                wrenchSocket.transform.position = this.gameObject.transform.position;
                wrenchSocket.transform.rotation = this.gameObject.transform.rotation;
                wrenchSocket.transform.SetParent(this.gameObject.transform);
                break;
                default:
                break;
        }
    }
}
