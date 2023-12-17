using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;

public class WelderTool : MonoBehaviour
{
    public GameObject flames;

    private bool hasPickedUp = false;


    public InputActionProperty leftSelect;
    public InputActionProperty rightSelect;
    // Start is called before the first frame update
    void Start()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            hasPickedUp = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            hasPickedUp=false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(hasPickedUp && leftSelect.action.ReadValue<float>() >0.1f)
        {
            flames.SetActive(true);
            GameManager.Instance.Welding = true;
        }
        else if(hasPickedUp && rightSelect.action.ReadValue<float>() >0.1f)
        {
            flames.SetActive(true);
            GameManager.Instance.Welding = true;
        }
        else
        {
            flames.SetActive(false);
            GameManager.Instance.Welding = false;
        }
    }

}
