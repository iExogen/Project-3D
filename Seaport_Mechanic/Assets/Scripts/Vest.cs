using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vest : MonoBehaviour
{
    public GameObject centerEyeAnchor;
    private float rotationSpeed = 100;
    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(centerEyeAnchor.transform.position.x, centerEyeAnchor.transform.position.y, centerEyeAnchor.transform.position.z); ;

        var rotationDifference = Mathf.Abs(centerEyeAnchor.transform.eulerAngles.y - transform.eulerAngles.y);
        var finalRotationSpeed = rotationSpeed;

        if (rotationDifference > 60)
        {
            finalRotationSpeed = rotationSpeed * 2;
        }
        else if (rotationDifference > 40)
        {
            finalRotationSpeed = rotationSpeed;
        }
        else if (rotationDifference > 20)
        {
            finalRotationSpeed = rotationSpeed / 2;
        }
        else if (rotationDifference > 0)
        {
            finalRotationSpeed = rotationSpeed / 4;
        }

        var step = finalRotationSpeed * Time.deltaTime;

        transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(0, centerEyeAnchor.transform.eulerAngles.y, 0), step);
    }
}
