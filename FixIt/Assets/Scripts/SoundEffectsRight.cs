using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class SoundEffectsRight : MonoBehaviour
{
    public AudioSource screwDriver;

    public InputActionProperty rightActivate;

    private bool isPickedUp = false;
    private bool isUnlocked = true;
    // Start is called before the first frame update
    void Start()
    {
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "ScrewDriver")
        {
            isPickedUp = true;
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag == "ScrewDriver")
        {
            isPickedUp = false;
        }
    }


    // Update is called once per frame
    void Update()
    {
     if(rightActivate.action.ReadValue<float>() > 0.1f && isPickedUp && isUnlocked)
        {
            isUnlocked = false;
            screwDriver.Play();
        }
     else if(rightActivate.action.ReadValue<float>() < 0.1f && !isUnlocked)
        {
            isUnlocked=true;
            screwDriver.Stop();
        }
    }
}
