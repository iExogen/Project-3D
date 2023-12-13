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

    public GameObject hammerWarningSign;
    public GameObject welderWarningSign;
    private int repairedPieces = 0;
    public GameObject WelderSphere;

    public AudioSource hammerSound;
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
            hammerSound.Play();
            hammerHits++;
            if(hammerHits>=3)
            {
                hasHammered=true;
                brokenPlate.SetActive(false);
                fixedPlate.SetActive(true);
                hammerWarningSign.SetActive(false);
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (!hasHammered) return;
        if(GameManager.Instance.Welding && toolCollision)
        {
            repairedPieces++;
            currentCollider.GetComponent<MeshRenderer>().enabled = true;
            if(repairedPieces==24)
            {
                GameManager.Instance.repairsDone++;
                welderWarningSign.SetActive(false);
                WelderSphere.SetActive(false);
            }
        }
    }
}
