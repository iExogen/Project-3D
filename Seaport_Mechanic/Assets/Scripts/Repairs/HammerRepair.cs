using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HammerRepair : MonoBehaviour
{
    public GameObject repairedObject;
    private GameObject spawnObject;
    private int hitsOnEngine = 0;

    public GameObject sparks;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Hammer")
        {
            hitsOnEngine++;
            if(hitsOnEngine == 3)
            {
                spawnObject = Instantiate(repairedObject);
                spawnObject.transform.position = this.transform.position;
                spawnObject.transform.rotation = this.transform.rotation;
                this.gameObject.SetActive(false);
                GameManager.Instance.repairsDone++;
                sparks.SetActive(false);
            }

        }
    }
}
