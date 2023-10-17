using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TextFiller : MonoBehaviour
{
    // Start is called before the first frame update
    public TMP_Text PlayerName;
    public TMP_Text scoreCounter;
    public TMP_Text NPC1Score;
    public TMP_Text NPC2Score;
    public TMP_Text NPC4Score;
    public TMP_Text NPC5Score;
    public TMP_Text NPC6Score;
    private string PlayerNameString;
    private float timeBetweenNPCScore = 10;
    void Start()
    {
        PlayerNameString = LanguageManager.Instance.GetText(LanguageManager.TextID.PlayerNameText);
        PlayerName.text = PlayerNameString; 
        scoreCounter.text = LanguageManager.Instance.GetText(LanguageManager.TextID.ScoreText)+GameManager.Instance.RepairsNeeded;
        NPC1Score.text = LanguageManager.Instance.GetText(LanguageManager.TextID.ScoreText) + (10 - GameManager.Instance.npcRepairs);
        NPC2Score.text = LanguageManager.Instance.GetText(LanguageManager.TextID.ScoreText) + (10 - GameManager.Instance.npcRepairs);
        NPC4Score.text = LanguageManager.Instance.GetText(LanguageManager.TextID.ScoreText) + (10 - GameManager.Instance.npcRepairs);
        NPC5Score.text = LanguageManager.Instance.GetText(LanguageManager.TextID.ScoreText) + (10 - GameManager.Instance.npcRepairs);
        NPC6Score.text = LanguageManager.Instance.GetText(LanguageManager.TextID.ScoreText) + (10 - GameManager.Instance.npcRepairs);
    }

    // Update is called once per frame
    void Update()
    {
        scoreCounter.text = scoreCounter.text = LanguageManager.Instance.GetText(LanguageManager.TextID.ScoreText) + GameManager.Instance.RepairsNeeded;
        if(Time.time > timeBetweenNPCScore*(GameManager.Instance.npcRepairs + 1))
        {
            GameManager.Instance.npcRepairs++;
            NPC1Score.text = LanguageManager.Instance.GetText(LanguageManager.TextID.ScoreText) + (10-GameManager.Instance.npcRepairs);
            NPC2Score.text = LanguageManager.Instance.GetText(LanguageManager.TextID.ScoreText) + (10-GameManager.Instance.npcRepairs);
            NPC4Score.text = LanguageManager.Instance.GetText(LanguageManager.TextID.ScoreText) + (10-GameManager.Instance.npcRepairs);
            NPC5Score.text = LanguageManager.Instance.GetText(LanguageManager.TextID.ScoreText) + (10-GameManager.Instance.npcRepairs);
            NPC6Score.text = LanguageManager.Instance.GetText(LanguageManager.TextID.ScoreText) + (10-GameManager.Instance.npcRepairs);
        }
    }
}
