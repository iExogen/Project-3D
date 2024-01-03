using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ReturnTools : MonoBehaviour
{

    public Transform hand;
    public GameObject slot;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, hand.position) > 3f && Vector3.Distance(transform.position,slot.transform.position)>5f)
        {
            transform.position = new Vector3(slot.transform.position.x, slot.transform.position.y + 2f,slot.transform.position.z);
        }
    }
}
