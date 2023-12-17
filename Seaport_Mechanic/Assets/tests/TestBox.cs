using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestBox : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<Animator>().Play("Box");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
