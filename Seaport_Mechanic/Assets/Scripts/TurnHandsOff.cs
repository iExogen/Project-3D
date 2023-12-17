using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;

public class TurnHandsOff : MonoBehaviour
{
    public InputActionProperty leftGrab;
    public InputActionProperty rightGrab;

    public GameObject leftHand;
    public GameObject rightHand;

    private bool hasPickedUp = false;
    private bool isInteracting = false;
    string[] grabbableTags = {"Hammer","ScrewDriver","Wrench","Plier","Helmet","Vest","Boots" };
    private bool resetClick;

    private void Start()
    {
    }
    private void OnTriggerEnter(Collider other)
    {
        if(grabbableTags.Contains(other.tag))
        {
            isInteracting = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (grabbableTags.Contains(other.tag))
        {

            isInteracting = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        PickUp();
    }

    void PickUp()
    {
        if (leftGrab.action.ReadValue<float>() > 0.1f  && !hasPickedUp && isInteracting && resetClick)
        {
            leftHand.SetActive(false);
            hasPickedUp = true;
            resetClick = false;
        }
        else if (rightGrab.action.ReadValue<float>() > 0.1f && !hasPickedUp && isInteracting && resetClick)
        {
            rightHand.SetActive(false);
            hasPickedUp = true;
            resetClick = false;
        }
        else if(rightGrab.action.ReadValue<float>()>0.1f && hasPickedUp && isInteracting && resetClick)
        {
            rightHand.SetActive(true);
            hasPickedUp=false;
            resetClick = false;
        }
        else if(leftGrab.action.ReadValue<float>()>0.1f && hasPickedUp && isInteracting && resetClick)
        {
            leftHand.SetActive(true);
            hasPickedUp = false;
            resetClick = false;
        }

        if(leftGrab.action.ReadValue<float>()<0.1f && rightGrab.action.ReadValue<float>()<0.1f)
        {
            resetClick = true;
        }
    }

}
