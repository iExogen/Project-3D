using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VestPosition : MonoBehaviour
{
    public GameObject _camera;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(_camera.transform.position.x,_camera.transform.position.y-.2f,_camera.transform.position.z);
        transform.LookAt(new Vector3(_camera.transform.rotation.x, _camera.transform.rotation.y, _camera.transform.rotation.z));
    }
}
