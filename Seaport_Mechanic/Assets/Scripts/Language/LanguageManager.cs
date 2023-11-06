using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LanguageManager : Singleton<LanguageManager>
{
    public enum Language
    {
        English,
        Nederlands,
        Arabic
    }
    public enum TextID
    {
        PlayerNameText,
        ScoreText,
        ScoreDone,
        StartButton,
        EndButton,
        RestartButton,
        EndScreenSucces,
        EndScreenFailure,
    }
    public Language chosenLanguage = Language.English;
    private Dictionary<Language, Dictionary<TextID, string>> allTexts = new Dictionary<Language, Dictionary<TextID, string>>();
    // Start is called before the first frame update
    void Start()
    {      
        InitAllText();

    }

    public string GetText(TextID textID) //returns text based on ID and chosenLanguage
    {
       
        if (allTexts.ContainsKey(chosenLanguage))
        {
            string result;
            if(allTexts[chosenLanguage].TryGetValue(textID, out result))
            {
                return result;
            }
            else
            {
                return "text not found in LanguageManager";
            }
        }
        return "language not found in languageManager";
    }
    public void AddElement(Language lang,TextID id,string text)
    { 
        if(allTexts.ContainsKey(lang))
        {
            if(!allTexts[lang].ContainsKey(id))
            {
                allTexts[lang].Add(id, text);
            }       
        }
        else
        {
            allTexts.Add(lang, new Dictionary<TextID, string>());
            allTexts[lang].Add(id, text);
        }
    }

    private void InitAllText()
    {
        AddElement(Language.English, TextID.PlayerNameText, "Player1");
        AddElement(Language.Nederlands, TextID.PlayerNameText, "Speler1");

        AddElement(Language.English, TextID.ScoreText, "Current repairs: ");
        AddElement(Language.Nederlands, TextID.ScoreText, "Huidige reparaties: ");

        AddElement(Language.English, TextID.ScoreDone, "DONE");
        AddElement(Language.Nederlands, TextID.ScoreDone, "GEDAAN");

        AddElement(Language.English, TextID.StartButton, "Start");
        AddElement(Language.Nederlands, TextID.StartButton, "Starten");

        AddElement(Language.English, TextID.EndButton, "Finish");
        AddElement(Language.Nederlands, TextID.EndButton, "Eindig");

        AddElement(Language.English, TextID.RestartButton, "restart");
        AddElement(Language.Nederlands, TextID.RestartButton, "herstarten");

        AddElement(Language.English, TextID.EndScreenSucces, "You finished ");
        AddElement(Language.Nederlands, TextID.EndScreenSucces, "je bent geindigt op plaats ");

        AddElement(Language.English, TextID.EndScreenFailure, "You didn't finish your repairs!");
        AddElement(Language.Nederlands, TextID.EndScreenFailure, "je hebt je reparaties niet afgemaakt!");
    }

}
