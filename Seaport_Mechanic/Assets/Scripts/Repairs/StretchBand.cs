using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class StretchBand : MonoBehaviour
{
    public InputActionProperty leftActivate;
    public InputActionProperty rightActivate;

    public bool isColliding = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Plier")
        {
            isColliding = true;
        }
    }
    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Plier")
        {
            isColliding = false;
        }

    }

    // Update is called once per frame
    void Update()
    {
        if(isColliding && leftActivate.action.triggered)
        {
            this.GetComponent<Rigidbody>().isKinematic = false;
        }
    }
}
