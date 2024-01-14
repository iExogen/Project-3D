using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class WelderMask : MonoBehaviour
{
    public GameObject mask;
    public GameObject torch;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }



    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(gameObject.transform.position, torch.transform.position) > 5f)
        {
            mask.SetActive(true);
        }
        else
        {
            mask.SetActive(false);
        }
    }
}
