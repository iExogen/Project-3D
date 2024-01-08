using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class WrenchOnWheel : MonoBehaviour
{
    public GameObject wrench;
    public Wrench _Wrench;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        if(gameObject.GetComponent<HingeJoint>().angle>=400)
        {
            gameObject.SetActive(false);
            wrench.SetActive(true);
            _Wrench.screwsfixed++;
        }
    }
}
