using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HammerRepair : MonoBehaviour
{
    public GameObject repairedObject;
    private GameObject spawnObject;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Hammer")
        {
            spawnObject = Instantiate(repairedObject);
            spawnObject.transform.position = this.transform.position;
            spawnObject.transform.rotation = this.transform.rotation;
            this.gameObject.SetActive(false);

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
