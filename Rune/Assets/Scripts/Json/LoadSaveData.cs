using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class LoadSaveData : MonoBehaviour
{
    /*
    [SerializeField] private SaveData m_save1;
    [SerializeField] private SaveData m_save2;
    [SerializeField] private SaveData m_save3;
    */
    // Start is called before the first frame update
    public void onQuitSaveData(int highScore) //saving
    {
        SaveData data = new SaveData();
        data.m_highScore = highScore.ToString();
        string json = JsonUtility.ToJson(data);
        File.WriteAllText(Application.dataPath + "/SaveData.json", json);
        PlayerPrefs.SetString("HighScore", "True");
    }

    public string awakeLoadData(string highScoreKey)

    {   
        if(PlayerPrefs.HasKey(highScoreKey))
        {
            string json = File.ReadAllText(Application.dataPath + "/SaveData.json");
            SaveData data = JsonUtility.FromJson<SaveData>(json);
            return data.m_highScore;

        }
        else
        {
            return "0";
        }
        

    }


}
