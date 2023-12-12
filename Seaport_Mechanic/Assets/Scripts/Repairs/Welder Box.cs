using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WelderBox : MonoBehaviour
{

    private bool toolCollision = false;
    private GameObject currentCollider;

    public GameObject brokenPlate;
    public GameObject fixedPlate;
    private int hammerHits = 0;
    private bool hasHammered = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Welder"))
        {
            toolCollision = true;
            currentCollider = collision.GetContact(0).thisCollider.gameObject;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Welder"))
        {
            toolCollision = false;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Hammer"))
        {
            hammerHits++;
            if(hammerHits>=3)
            {
                hasHammered=true;
                brokenPlate.SetActive(false);
                fixedPlate.SetActive(true);
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (!hasHammered) return;
        if(GameManager.Instance.Welding && toolCollision)
        {
            currentCollider.GetComponent<MeshRenderer>().enabled = true;
        }
    }
}
