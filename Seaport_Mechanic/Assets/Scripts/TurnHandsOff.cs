using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.InputSystem;

public class TurnHandsOff : MonoBehaviour
{
    public InputActionProperty leftGrab;
    public InputActionProperty rightGrab;


    public GameObject leftHand;
    public GameObject rightHand;
    private bool isGrabbable = false;

    private bool isPressing = false;

    string[] grabbableTags = {"Hammer","ScrewDriver","Wrench","Plier","Helmet","Vest","Boots" };
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(grabbableTags.Contains(other.tag))
        {
            isGrabbable = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (grabbableTags.Contains(other.tag))
        {
            isGrabbable = false;
        }
    }
    // Update is called once per frame
    void Update()
    {
        if(leftGrab.action.ReadValue<float>() >0.1f && isGrabbable && !isPressing)
        {
            leftHand.SetActive(!leftHand.activeSelf);
            isPressing = true;
        }
        else if (rightGrab.action.ReadValue<float>() > 0.1f && isGrabbable && !isPressing)
        {
            rightHand.SetActive(!rightHand.activeSelf );
            isPressing = true;
        }
        if(leftGrab.action.ReadValue<float>() <0.1f && rightGrab.action.ReadValue<float>() < 0.1f)
        {
            isPressing = false;
        }
    }
}
