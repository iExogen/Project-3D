using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class EquipGear : MonoBehaviour
{

    public GameObject vest;
    public GameObject helmet;
    public GameObject bootLeft;
    public GameObject bootRight;
    public GameObject Glasses;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            GameManager.Instance.equipedItems = true;
            helmet.SetActive(false);
            vest.SetActive(false);
            bootLeft.SetActive(false);
            bootRight.SetActive(false);
            Glasses.SetActive(false);

        }
    }


}
