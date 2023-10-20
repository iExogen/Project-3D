using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TextFiller : MonoBehaviour
{
    // Start is called before the first frame update
    public TMP_Text PlayerName;
    public TMP_Text PlayerScore;
    public TMP_Text NPC1Score;
    public TMP_Text NPC2Score;
    public TMP_Text NPC3Score;
    public TMP_Text NPC5Score;
    public TMP_Text NPC6Score;

    public Slider playerSlider;
    public Slider NPC1Slider;
    public Slider NPC2SLider;
    public Slider NPC3Slider;
    public Slider NPC5Slider;
    public Slider npc6Slider;

    private string PlayerNameString;
    private float npcScore = 0;
    private float timeBetweenNPCScore = 10;
    void Start()
    {
        PlayerNameString = LanguageManager.Instance.GetText(LanguageManager.TextID.PlayerNameText);
        PlayerName.text = PlayerNameString; 
        PlayerScore.text = LanguageManager.Instance.GetText(LanguageManager.TextID.ScoreText)+GameManager.Instance.repairsDone;
        NPC1Score.text = LanguageManager.Instance.GetText(LanguageManager.TextID.ScoreText) + npcScore;
        NPC2Score.text = LanguageManager.Instance.GetText(LanguageManager.TextID.ScoreText) + npcScore;
        NPC3Score.text = LanguageManager.Instance.GetText(LanguageManager.TextID.ScoreText) + npcScore;
        NPC5Score.text = LanguageManager.Instance.GetText(LanguageManager.TextID.ScoreText) + npcScore;
        NPC6Score.text = LanguageManager.Instance.GetText(LanguageManager.TextID.ScoreText) + npcScore;
    }

    // Update is called once per frame
    void Update()
    {
        PlayerScore.text = PlayerScore.text = LanguageManager.Instance.GetText(LanguageManager.TextID.ScoreText) + GameManager.Instance.repairsDone;
        if(Time.time > timeBetweenNPCScore*(npcScore+1))
        {
            npcScore++;
            NPC1Score.text = LanguageManager.Instance.GetText(LanguageManager.TextID.ScoreText) + npcScore;
            NPC2Score.text = LanguageManager.Instance.GetText(LanguageManager.TextID.ScoreText) + npcScore;
            NPC3Score.text = LanguageManager.Instance.GetText(LanguageManager.TextID.ScoreText) + npcScore;
            NPC5Score.text = LanguageManager.Instance.GetText(LanguageManager.TextID.ScoreText) + npcScore;
            NPC6Score.text = LanguageManager.Instance.GetText(LanguageManager.TextID.ScoreText) + npcScore;
        }
    }
}
