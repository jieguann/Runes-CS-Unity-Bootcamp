using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

/// <summary>
/// Attach this to the GameManager
/// User will click on button and this will 
/// tell us if they clikced on the right button
/// </summary>
public class RuneSelector : MonoBehaviour
{
    [SerializeField] private AudioSource m_as;
    public  int[] m_currentRuneSequence = new[] { 0, 1, 2, 3 };
    public  int m_currentIndex = 0;
    [SerializeField] private TMP_Text m_announcerText;


    [SerializeField] private GameManager m_GMScript;
    public void OnRuneActivated(int index)
    {
        if (m_currentIndex >= m_currentRuneSequence.Length) return;
        if(m_currentRuneSequence[m_currentIndex] == index)
        {
            CorrectSelected();
            //m_currentIndex++;
        }

        else
        {
            //m_currentIndex = 0;
            Failed();
            //Func();
            //StartCoroutine(DisplayGoText());
        }
    }

    private void Failed()
    {

        m_currentIndex = 0;
        //m_announcerText.text = "Failed";
    }

    private void CorrectSelected()
    {
        m_currentIndex++;
        m_as.Play();
        GameManager.s_instance.AddScore(10);
        //Logic
        SequeceCompleted();
    }

    private void SequeceCompleted()
    {
        //throw new NotImplementedException();
    }


    /*
    IEnumerator DisplayGoText()
    {
        m_announcerText.text = "Failed";
        yield return new WaitForSeconds(1f);
        m_announcerText.text = "3";
        yield return new WaitForSeconds(1f);
        m_announcerText.text = "2";
        yield return new WaitForSeconds(1f);
        m_announcerText.text = "1";
        yield return new WaitForSeconds(1f);
        m_announcerText.text = "Go";

    }
    */
}
