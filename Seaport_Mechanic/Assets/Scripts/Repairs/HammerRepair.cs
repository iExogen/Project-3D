using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class HammerRepair : MonoBehaviour
{
    private int hitsOnEngine = 0;


    public bool playsound = false;

    public GameObject watchSphere;
    public GameObject sparks;
    private bool needsRepair = true;

    public AudioSource hammerSound;
    private bool lilTwist = true;
    public GameObject DangerSign;

    public GameObject startBox;
    private void Start()
    {
    }
    private void OnTriggerEnter(Collider other)
    {
        if (!needsRepair) return;
        if(other.tag == "Hammer")
        {
            hammerSound.Play();
            if(hitsOnEngine <3)
            {
            GetComponent<Animator>().Play("LilTwist");
            hitsOnEngine++;
            }  
            if(hitsOnEngine == 3)
            {
                GetComponent<Animator>().Play("BigTwist");
                GameManager.Instance.repairsDone++;
                sparks.SetActive(false);
                needsRepair = false;
                watchSphere.SetActive(false);
                DangerSign.SetActive(false);
                lilTwist = false;
                startBox.SetActive(false);
            }
            playsound = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("Hammer"))
        {
            if(lilTwist)
            {
                GetComponent<Animator>().Play("Idle");
            }
        }
    }
}
