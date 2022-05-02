using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class SaveDataEasy : MonoBehaviour
{
    private string[] saveKey = new string[] {"Name", "Age", "City", "Weight"};
    [SerializeField] TMP_InputField[] inputText;
    [SerializeField] TMP_Text[] initDisplayText;
    // Start is called before the first frame update

    private void Awake()
    {
        for (int i = 0; i < saveKey.Length; i++)
        {
            if (PlayerPrefs.HasKey(saveKey[i]))
            {
                initDisplayText[i].text = PlayerPrefs.GetString(saveKey[i]);
                //m_highScore = PlayerPrefs.GetInt(loadSaveData.awakeLoadData(m_scoreKey));

                //m_highScoreText.text = m_highScore.ToString();
                

            }
        }

            
    }

    public void SaveData()
    {
        for(int i=0;i<saveKey.Length;i++)
        {
            PlayerPrefs.SetString(saveKey[i], inputText[i].text);
            //print(inputText[i].text);
        }
        
    }
}
