using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HammerRepair : MonoBehaviour
{
    public GameObject repairedObject;
    private GameObject spawnObject;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Hammer")
        {
            spawnObject = Instantiate(repairedObject);
            spawnObject.transform.position = this.transform.position;
            spawnObject.transform.rotation = this.transform.rotation;
            this.gameObject.SetActive(false);
            GameManager.Instance.totalRepairs =- 1;

        }
    }
}
