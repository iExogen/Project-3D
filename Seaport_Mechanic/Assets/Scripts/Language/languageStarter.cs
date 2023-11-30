using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.XR.Interaction.Toolkit;

public class languageStarter : MonoBehaviour
{
    private enum LanguageFlag
    {
        belgian,
        american,
    }
    public Collider UkArican;
    public Collider Belgerland;

    public GameObject UkaricanIndicator;
    private Transform ukaricanStartPos;
    public GameObject BelgerlandIndicator;
    private Transform BelgerlandStartPos;
    // Start is called before the first frame update
    void Start()
    {
        ukaricanStartPos = UkaricanIndicator.transform;
        BelgerlandStartPos = BelgerlandIndicator.transform;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Crayon"))
        {
            if (collision.GetContact(0).thisCollider == UkArican)
            {
                LanguageManager.Instance.chosenLanguage = LanguageManager.Language.English;
                BelgerlandIndicator.transform.position = BelgerlandStartPos.position;
                UkaricanIndicator.transform.position += new Vector3(0, 0, 0.0013f);
            }
            else if(collision.GetContact(0).thisCollider == Belgerland)
            {
                LanguageManager.Instance.chosenLanguage = LanguageManager.Language.Nederlands;
                UkaricanIndicator.transform.position = ukaricanStartPos.position;
                BelgerlandIndicator.transform.position += new Vector3(0, 0, 0.0013f);
            }
        }
    }
}
