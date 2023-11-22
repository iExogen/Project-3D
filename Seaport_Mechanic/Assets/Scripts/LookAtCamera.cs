using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtCamera : MonoBehaviour
{
    public Transform head;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.LookAt(new Vector3(head.position.x, this.transform.position.y, head.position.z));
        this.transform.forward *= -1;

    }
}
