using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Wrench : MonoBehaviour
{
    public GameObject[] wrenches;
    public GameObject[] screws;
    public int screwsfixed = 0;
    public Animator wheelFall;
    private bool keepOldWheel = true;
    public GameObject repairedWheel;
    public GameObject sparks;
    // Start is called before the first frame update
    void Start()
    {
    }

    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.CompareTag("Wrench"))
        {
            for(int i = 0; i < wrenches.Length; i++)
            {
                if (other.GetContact(0).thisCollider.gameObject == screws[i])
                {
                    wrenches[i].SetActive(true);
                }
            }
            other.gameObject.transform.position = new Vector3(0, 0, 0);
            other.gameObject.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Wheel") && !keepOldWheel)
        {
            other.gameObject.SetActive(false);
            repairedWheel.SetActive(true);
            sparks.SetActive(false);
            GameManager.Instance.repairsDone++;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("Wheel")&& screwsfixed==4)
        {
            other.gameObject.SetActive(false);
            keepOldWheel = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(screwsfixed==4)
        {
            wheelFall.Play("WheelFall");
        }
    }
}
