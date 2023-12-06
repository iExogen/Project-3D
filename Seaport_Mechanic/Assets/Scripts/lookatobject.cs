using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lookatobject : MonoBehaviour
{
    public Transform lookAtTarget;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        this.transform.LookAt(new Vector3(lookAtTarget.position.x, lookAtTarget.position.y, lookAtTarget.position.z));
        this.transform.forward *= -1;

    }
}
