using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ScrewMachine : MonoBehaviour
{
    bool triggered = false;
    public InputActionProperty leftActivate;
    public InputActionProperty rightActivate;
    private GameObject screw;
    private void Start()
    {
    }

    void Update()
    {
        if (leftActivate.action.ReadValue<float>() > 0.1f && triggered)
        {
            screw.transform.localPosition = new Vector3(this.transform.position.y-0.5f, this.transform.position.x, this.transform.position.z);
        }
        else if(rightActivate.action.ReadValue<float>() > 0.1f && triggered)
        {

        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("ScrewDriver"))
        {
            triggered = true;
            screw = other.gameObject;
        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("ScrewDriver"))
        {
            triggered = false;
        }
    }
}
