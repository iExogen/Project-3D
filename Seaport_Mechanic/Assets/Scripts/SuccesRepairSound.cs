using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuccesRepairSound : MonoBehaviour
{
    public AudioSource ding;
    private int currentRepairs=0;
    private int doneRepairs=0;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        doneRepairs=GameManager.Instance.repairsDone;
        if(doneRepairs>currentRepairs)
        {
            ding.Play();
            currentRepairs=doneRepairs;
        }
    }
}
