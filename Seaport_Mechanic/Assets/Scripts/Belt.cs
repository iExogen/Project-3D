using System.Collections;
using System.Collections.Generic;
using System.Net.Http.Headers;
using UnityEngine;

public class Belt : MonoBehaviour
{
    public GameObject centerEyeAnchor;
    private float rotationSpeed = 100;
    public GameObject characterCenter;
    // Update is called once per frame
    void Update()
    {
        transform.position = characterCenter.transform.position +centerEyeAnchor.transform.forward*.5f+ new Vector3(0,1,0);
     

        var rotationDifference = Mathf.Abs(centerEyeAnchor.transform.eulerAngles.y - transform.eulerAngles.y);
        var finalRotationSpeed = rotationSpeed;

        if(rotationDifference > 60)
        {
            finalRotationSpeed = rotationSpeed * 2;
        }
        else if(rotationDifference > 40)
        {
            finalRotationSpeed = rotationSpeed;
        }
        else if(rotationDifference >20)
        {
            finalRotationSpeed = rotationSpeed / 2;
        }
        else if( rotationDifference >0)
        {
            finalRotationSpeed = rotationSpeed / 4;
        }

        var step = finalRotationSpeed * Time.deltaTime;

        transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(0, centerEyeAnchor.transform.eulerAngles.y, 0), step);
    }
}
