using Mirror;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using UnityEngine.XR.Interaction.Toolkit;

public class Menu : MonoBehaviour
{
    [SerializeField] bool test=false;
    public Transform head;
    public InputActionProperty menuButton;
    private bool isInvisible;

    public GameObject restartGame;
    public GameObject englishSelect;
    public GameObject dutchSelect;
    public GameObject resumeGame;
    // Start is called before the first frame update
    void Start()
    {
        isInvisible = false;
    }

    public void onCollisionEnter(Collision other)
    {
        /*
        test = true;
            if (other.GetContact(0).thisCollider.gameObject.name == "Restart Button")
            {
                GameManager.Instance.repairsDone = 0;
                GameManager.Instance.screwsFixed = 0;
                GameManager.Instance.screwsRemoved = 0;
                GameManager.Instance.equipedItems = false;
                SceneManager.LoadScene(0);
                LanguageManager.Instance.chosenLanguage = LanguageManager.Language.English;
            }
            else if(other.GetContact(0).thisCollider.gameObject.name == "EnglishButton")
            {
                LanguageManager.Instance.chosenLanguage = LanguageManager.Language.English;
            }
            else if(other.GetContact(0).thisCollider.gameObject.name == "DutchButton")
            {
                LanguageManager.Instance.chosenLanguage = LanguageManager.Language.Nederlands;
            }
            else if (other.GetContact(0).thisCollider.gameObject.name == "ResumeButton")
            {
                transform.position = new Vector3(0, -20, 0);
                isInvisible = true;
            }
        */
    }
    // Update is called once per frame
    void Update()
    {
       if(restartGame.activeSelf == false)
        {
            restartGame.SetActive(true);
            GameManager.Instance.repairsDone = 0;
            GameManager.Instance.screwsFixed = 0;
            GameManager.Instance.screwsRemoved = 0;
            GameManager.Instance.equipedItems = false;
            SceneManager.LoadScene(0);
            LanguageManager.Instance.chosenLanguage = LanguageManager.Language.English;
        }
       else if(englishSelect.activeSelf == false)
        {
            LanguageManager.Instance.chosenLanguage = LanguageManager.Language.English;
            englishSelect.SetActive(true);
        }
       else if(dutchSelect.activeSelf == false)
        {
            LanguageManager.Instance.chosenLanguage = LanguageManager.Language.Nederlands;
            dutchSelect.SetActive(true);
        }
       else if(resumeGame.activeSelf == false)
        {
            transform.position = new Vector3(0, -20, 0);
            isInvisible = true;
            resumeGame.SetActive(true);
        }
        if(menuButton.action.triggered)
        {
         if(isInvisible)
            {
                transform.position = head.position + new Vector3(head.forward.x, 0, head.forward.z).normalized;
                isInvisible = false;
            }
            else
            {
                transform.position = new Vector3(0, -20, 0);
                isInvisible = true;
            }
        }
        transform.LookAt(new Vector3(head.position.x, transform.position.y, head.position.z));
        transform.forward *= -1;


    }
}
