using System.Collections;
using System.Collections.Generic;
using Unity.XR.OpenVR;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.XR;
using UnityEngine.UI;


public class SoundEffectsRight : MonoBehaviour
{
    public AudioSource screwDriver;
    public AudioSource plier;
    public AudioSource welding;

    public InputActionProperty rightActivate;

    private string itemPickedUp = "";
    private bool isUnlocked = true;
    public GameObject weldingFlames;

    public GameObject weldingMask;
    // Start is called before the first frame update

    void Start()
    {
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "ScrewDriver")
        {
            itemPickedUp = "ScrewDriver";
            weldingMask.SetActive(false);
        }
        else if (other.gameObject.CompareTag("Plier"))
        {
            itemPickedUp = "Plier";
            weldingMask.SetActive(false);
        }
        else if (other.gameObject.CompareTag("Welder"))
        {
            itemPickedUp = "Welder";
            weldingMask.SetActive(true);

        }
        else
        {
            weldingMask.SetActive(false);
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
        else if (other.gameObject.CompareTag("Welder"))
        {
            itemPickedUp = "";
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (rightActivate.action.ReadValue<float>() > 0.1f && itemPickedUp == "ScrewDriver" && isUnlocked)
        {
            isUnlocked = false;
            screwDriver.Play();
        }
        else if (rightActivate.action.ReadValue<float>() > 0.1f && itemPickedUp == "Plier")
        {
            plier.Play();
        }
        else if (rightActivate.action.ReadValue<float>() > 0.1f && itemPickedUp == "Welder" && isUnlocked)
        {
            welding.Play();
            weldingFlames.SetActive(true);
            isUnlocked = false;
        }
        else if (rightActivate.action.ReadValue<float>() < 0.1f && !isUnlocked)
        {
            isUnlocked = true;
            screwDriver.Stop();
            welding.Stop();
            weldingFlames.SetActive(false);
        }
    }
}
