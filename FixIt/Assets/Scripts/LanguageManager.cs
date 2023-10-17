using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LanguageManager : Singleton<LanguageManager>
{
    public enum Language
    {
        English,
        Dutch,
        Arabic
    }
    public enum TextID
    {
        PlayerNameText,
        ScoreText,
    }
    public Language chosenLanguage = Language.Dutch;
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
        AddElement(Language.Dutch, TextID.PlayerNameText, "Speler1");

        AddElement(Language.English, TextID.ScoreText, "Repairs left: ");
        AddElement(Language.Dutch, TextID.ScoreText, "Overige reparaties: ");
    }

}
