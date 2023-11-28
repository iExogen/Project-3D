using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class SoundEffectsLeft : MonoBehaviour
{
    public AudioSource screwDriver;
    public AudioSource plier;
    public AudioSource hammer;
    public HammerRepair hammerRepairScript;

    public InputActionProperty leftActivate;

    private string itemPickedUp = "";
    private bool isUnlocked = true;
    // Start is called before the first frame update
    void Start()
    {
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "ScrewDriver")
        {
            itemPickedUp = "screwDriver";
        }
        else if (other.gameObject.CompareTag("Plier"))
        {
            itemPickedUp = "Plier";
        }
        else if(other.gameObject.CompareTag("Hammer"))
        {
            itemPickedUp = "Hammer";
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "ScrewDriver")
        {
            itemPickedUp = "";
        }
        else if (other.gameObject.CompareTag("Plier"))
        {
            itemPickedUp = "";
        }
        else if (other.gameObject.CompareTag("Hammer"))
        {
            itemPickedUp = "";
        }
    }


    // Update is called once per frame
    void Update()
    {
        if (leftActivate.action.ReadValue<float>() > 0.1f && itemPickedUp == "ScrewDriver" && isUnlocked)
        {
            isUnlocked = false;
            screwDriver.Play();
        }
        else if(leftActivate.action.ReadValue<float>() > 0.1f && itemPickedUp == "Plier")
        {
            plier.Play();
        }
        else if (hammerRepairScript.playsound && itemPickedUp == "Hammer")
        {
            hammer.Play();
            hammerRepairScript.playsound = false;
        }
        else if (leftActivate.action.ReadValue<float>() < 0.1f && !isUnlocked)
        {
            isUnlocked = true;
            screwDriver.Stop();
        }
    }
}
