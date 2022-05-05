using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class languageChange : MonoBehaviour
{
    [SerializeField] Button canada;
    [SerializeField] Button spanish;
    public string AnnouncerListenID = "AnnouncerListen";
    //[SerializeField] TMP_Text Annoucer;

    // Start is called before the first frame update
    void Start()
    {
        canada.onClick.AddListener(updateLocalCA);
        spanish.onClick.AddListener(updateLocalSP);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void updateLocalCA()
    {
        Localization.s_currenLocale = Locale.en;
        Debug.Log(Locale.en);
    }

    void updateLocalSP()
    {
        Localization.s_currenLocale = Locale.pt;
        Debug.Log(Locale.pt);
    }
}
