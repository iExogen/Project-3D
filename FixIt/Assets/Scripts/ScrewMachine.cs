using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrewMachine : MonoBehaviour
{
    bool triggered = false;

    private void Start()
    {
    }

    void Update()
    {
        if ( triggered)
        {
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("ScrewDriver"))
        {
            triggered = true;
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
