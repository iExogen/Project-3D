using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class StretchBand : MonoBehaviour
{
    public InputActionProperty leftActivate;
    public InputActionProperty rightActivate;

    public GameObject brokenStretch;
    public GameObject brokenStretchMovable;

    public bool isColliding = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Plier"))
        {
            isColliding = true;
        }
    }
    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Plier"))
        {
            isColliding = false;
        }

    }

    // Update is called once per frame
    void Update()
    {
        if(isColliding && leftActivate.action.triggered)
        {
            brokenStretch.gameObject.SetActive(false);
            brokenStretchMovable.SetActive(true);
        }
        if (isColliding && rightActivate.action.triggered)
        {
            brokenStretch.gameObject.SetActive(false);
            brokenStretchMovable.SetActive(true);
        }
    }
}
