using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DecideEnding : MonoBehaviour
{
    public Animator decideEndingAnimator;
    public float timer;

    public GameObject brokenStraddle;
    public GameObject movingStraddle;

    public TMP_Text successOrFailText;

    public CanvasGroup blackScreen;

    public char endingChoice;

    private bool badEndingChecked = false;

    public AudioSource driving;
    public AudioSource crashing;
    // Start is called before the first frame update
    void Start()
    {
     if(GameManager.Instance.repairsDone==5)
        {
            decideEndingAnimator.Play("Driving animation Good");
            endingChoice = 'G';
            successOrFailText.text = LanguageManager.Instance.GetText(LanguageManager.TextID.Succes);
            successOrFailText.color = Color.green;
        }
     else
        {
            decideEndingAnimator.Play("Driving animation Bad");
            endingChoice = 'B';
            successOrFailText.text = LanguageManager.Instance.GetText(LanguageManager.TextID.Fail);
            successOrFailText.color = Color.red;
        }
        driving.Play();
        timer = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if(endingChoice == 'B'&& Time.time >=timer+2.5f && !badEndingChecked)
        {
            movingStraddle.SetActive(false);
            brokenStraddle.SetActive(true);
            driving.Stop();
            crashing.Play();
            badEndingChecked = true;
        }
        if(Time.time >= timer+4f)
        {
            successOrFailText.gameObject.SetActive(true);
        }
        if(Time.time >= timer+15f)
        {
            GameManager.Instance.repairsDone = 0;
            GameManager.Instance.screwsFixed = 0;
            GameManager.Instance.screwsRemoved = 0;
            GameManager.Instance.equipedItems = false;
            SceneManager.LoadScene(0);
            LanguageManager.Instance.chosenLanguage = LanguageManager.Language.English;
        }

        blackScreen.alpha -= 0.01f;
    }
}
