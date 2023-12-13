using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class HammerRepair : MonoBehaviour
{
    private int hitsOnEngine = 0;

    public GameObject twistLock;

    public bool playsound = false;

    public GameObject watchSphere;
    public GameObject sparks;
    private bool needsRepair = true;

    public AudioSource hammerSound;

    public GameObject DangerSign;
    private void Start()
    {
        this.GetComponent<Animator>().Play("Armature | Full Twist_002");
    }
    private void OnTriggerEnter(Collider other)
    {
        if (!needsRepair) return;
        if(other.tag == "Hammer")
        {
            hammerSound.Play();
            if(hitsOnEngine <3)
            {
            twistLock.GetComponent<Animator>().Play("LilTwist");
            hitsOnEngine++;
            }  
            if(hitsOnEngine == 3)
            {
                twistLock.GetComponent<Animator>().Play("Armature | Full Twist_002");
                GameManager.Instance.repairsDone++;
                sparks.SetActive(false);
                needsRepair = false;
                watchSphere.SetActive(false);
                DangerSign.SetActive(false);
            }
            playsound = true;

        }
    }
}
