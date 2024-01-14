using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WelderMask : MonoBehaviour
{
    public GameObject mask;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Welder"))
        {
            mask.SetActive(true);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Welder"))
        {
            mask.SetActive(false);
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
