using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wrench : MonoBehaviour
{
    public GameObject screwsWrench;
    private bool repairing=false;
    private Vector3 startWrenchPos;
    public int screwsfixed = 0;
    // Start is called before the first frame update
    void Start()
    {
        startWrenchPos = screwsWrench.transform.position;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Wrench"))
        {
            other.gameObject.SetActive(false);
            repairing=true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (!repairing) return;

        screwsWrench.SetActive(true);
        

    }
}
