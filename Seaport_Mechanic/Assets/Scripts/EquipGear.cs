using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class EquipGear : MonoBehaviour
{
    string[] equipment = { "Helmet","Boots","Vest" };
    private void OnTriggerEnter(Collider other)
    {
        if(equipment.Contains(other.tag) && this.CompareTag(other.tag))
        {
            other.transform.root.gameObject.SetActive(false);
            other.gameObject.SetActive(false);
            this.transform.GetChild(0).gameObject.SetActive(true);
        }
    }
}
