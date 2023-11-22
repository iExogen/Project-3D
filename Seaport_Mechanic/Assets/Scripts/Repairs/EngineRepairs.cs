using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EngineRepairs : MonoBehaviour
{
    public bool oldStretchInPlace;
    public GameObject brokenStretchMovable;
    public GameObject repairedStretch;
    public GameObject repairedStretchMovable;
    public GameObject sparks;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == brokenStretchMovable)
        {
            oldStretchInPlace = false;
            other.gameObject.SetActive(false);
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject ==  repairedStretchMovable)
        {
            GameManager.Instance.repairsDone++;
            repairedStretchMovable.SetActive(false);
            repairedStretch.SetActive(true);
            sparks.SetActive(false);
        }
    }
}
