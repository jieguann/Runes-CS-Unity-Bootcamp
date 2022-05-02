using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TestEvent : MonoBehaviour
{
    [SerializeField] private UnityEvent m_click;
    [SerializeField] private AudioSource rune02Audio;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            m_click.Invoke();
        }
    }

    public void TestCall()
    {
        Debug.Log("Eli is Cool!");
        rune02Audio.Play();
    }
}
