using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TextFiller : MonoBehaviour
{
    // Start is called before the first frame update
    public TMP_Text introText;
    public TMP_Text scoreCounter;
    public TMP_Text NPC1Score;
    public TMP_Text NPC2Score;
    private string introTextString;
    private float npcScore = 0;
    private float timeBetweenNPCScore = 10;
    void Start()
    {
        introTextString = LanguageManager.Instance.GetText(LanguageManager.TextID.PlayerNameText);
        introText.text = introTextString; 
        scoreCounter.text = LanguageManager.Instance.GetText(LanguageManager.TextID.ScoreText)+GameManager.Instance.repairsDone;
        NPC1Score.text = LanguageManager.Instance.GetText(LanguageManager.TextID.ScoreText) + npcScore;
        NPC2Score.text = LanguageManager.Instance.GetText(LanguageManager.TextID.ScoreText) + npcScore;
    }

    // Update is called once per frame
    void Update()
    {
        scoreCounter.text = scoreCounter.text = LanguageManager.Instance.GetText(LanguageManager.TextID.ScoreText) + GameManager.Instance.repairsDone;
        if(Time.time > timeBetweenNPCScore*(npcScore+1))
        {
            npcScore++;
            NPC1Score.text = LanguageManager.Instance.GetText(LanguageManager.TextID.ScoreText) + npcScore;
            NPC2Score.text = LanguageManager.Instance.GetText(LanguageManager.TextID.ScoreText) + npcScore;
        }
    }
}
