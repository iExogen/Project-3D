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

    public AudioSource chalk;

    public GameObject UkaricanIndicator;
    private Vector3 ukaricanStartPos;
    public GameObject BelgerlandIndicator;
    private Vector3 BelgerlandStartPos;
    // Start is called before the first frame update
    void Start()
    {
        ukaricanStartPos = UkaricanIndicator.transform.position;
        BelgerlandStartPos = BelgerlandIndicator.transform.position;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            if (collision.GetContact(0).thisCollider == UkArican)
            {
                LanguageManager.Instance.chosenLanguage = LanguageManager.Language.English;
                BelgerlandIndicator.transform.position = BelgerlandStartPos;
                UkaricanIndicator.transform.position = ukaricanStartPos +new Vector3(0, 0, 0.0013f);
                chalk.Play();
            }
            else if(collision.GetContact(0).thisCollider == Belgerland)
            {
                LanguageManager.Instance.chosenLanguage = LanguageManager.Language.Nederlands;
                UkaricanIndicator.transform.position = ukaricanStartPos;
                BelgerlandIndicator.transform.position = BelgerlandStartPos + new Vector3(0, 0, 0.0013f);
                chalk.Play();
            }
        }
    }
}
