using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class WrenchOnWheel : MonoBehaviour
{
    public GameObject wrenchObject;
    public Wrench _Wrench;
    public GameObject screw;

    [SerializeField]private float startAngleZ;
    [SerializeField]private float turnedAngleWrench;
    // Start is called before the first frame update
    void Start()
    {
        startAngleZ = transform.rotation.z*180f;
    }
    // Update is called once per frame
    void Update()
    {
        turnedAngleWrench=Mathf.Abs(startAngleZ-(transform.rotation.z*180f));
        if(turnedAngleWrench>=30f)
        {
            gameObject.SetActive(false);
            wrenchObject.SetActive(true);
            _Wrench.screwsfixed++;
            screw.gameObject.SetActive(false);
        }
    }
}
