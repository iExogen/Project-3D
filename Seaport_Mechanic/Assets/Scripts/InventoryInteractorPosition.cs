using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryInteractorPosition : MonoBehaviour
{
    public GameObject finger;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = finger.transform.position;
        this.transform.rotation = Quaternion.Euler(0, 0, 0);
    }
}
