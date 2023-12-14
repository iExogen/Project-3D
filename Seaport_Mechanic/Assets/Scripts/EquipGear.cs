using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class EquipGear : MonoBehaviour
{
    private float wait5seconds = 0;
    private bool isHolding = false;
    public GameObject vest;
    public GameObject helmet;
    public GameObject boots;
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            isHolding = true;
            wait5seconds = Time.time;
            
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            isHolding = false;
        }
    }
    private void Update()
    {
        if (wait5seconds <= Time.time-5f && isHolding)
        {
            GameManager.Instance.equipedItems++;
            this.transform.parent.gameObject.SetActive(false);
            switch (this.tag)
            {
                case "Helmet":
                    helmet.SetActive(true);
                    break;
                case "Vest":
                    vest.SetActive(true);
                    break;
                case "Boots":
                    boots.SetActive(true);
                    break;
            }
        }
    }
}
