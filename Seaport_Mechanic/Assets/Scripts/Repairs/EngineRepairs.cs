using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EngineRepairs : MonoBehaviour
{

    public bool oldStretchInPlace = true;
    public GameObject repairedStretch;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "StretchBand")
        {
            oldStretchInPlace = false;
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.tag == "StretchBand" && !oldStretchInPlace)
        {
            GameManager.Instance.repairsDone++;
            other.gameObject.SetActive(false);
            repairedStretch.SetActive(true);
        }
    }
}
