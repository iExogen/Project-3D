using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrewPlate : MonoBehaviour
{
    public GameObject screwPlateFixedPos;
    public GameObject screwPlateFixedMovable;
    public GameObject screwPlateBrokenPos;
    public GameObject screwPlateBrokenMovable;
    public GameObject sparks;

    public GameObject dangerSignDrill;
    public GameObject dangerSignPlate;
    public GameObject WatchSphere;

    private bool removedPlate = false;
    private bool AddRepair = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "ScrewPlatesBroken")
        {
            screwPlateBrokenMovable.SetActive(false);
            removedPlate = true;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("ScrewPlatesFixed") && removedPlate)
        {
            screwPlateFixedMovable.gameObject.SetActive(false);
            screwPlateFixedPos.SetActive(true);
            dangerSignPlate.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(GameManager.Instance.screwsRemoved == 3)
        {
            screwPlateBrokenPos.SetActive(false);
            screwPlateBrokenMovable.SetActive(true);
        }
        if(GameManager.Instance.screwsFixed == 6 && AddRepair)
        {
            AddRepair = false;
            GameManager.Instance.repairsDone++;
            WatchSphere.SetActive(false);
            sparks.SetActive(false);
            dangerSignDrill.SetActive(false);
        }
    }
}
