using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarMainTurn : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        this.transform.rotation = Quaternion.Euler(0, 180, 0);
        this.GetComponent<StarMainTurn>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
