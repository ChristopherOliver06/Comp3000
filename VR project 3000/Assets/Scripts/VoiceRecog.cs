using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows.Speech;
using System.Linq;


public class VoiceRecog : MonoBehaviour
{
    public GameObject SphereTest;
    public GameObject CubeTest;
    private KeywordRecognizer SpellKeywordRecog;
    private Dictionary<string, Action> actions = new Dictionary<string, Action>();
    
   


    private void Start()
    {
        actions.Add("cube", Cube);
        actions.Add("sphere", Sphere);


        SpellKeywordRecog = new KeywordRecognizer(actions.Keys.ToArray());
        SpellKeywordRecog.OnPhraseRecognized += SpeechDetected;
        SpellKeywordRecog.Start();
    }

    private void SpeechDetected(PhraseRecognizedEventArgs speech)

    {
        Debug.Log(speech.text);

        actions[speech.text].Invoke();

    }

    private void Cube()
    {
        Debug.Log("test");
        Instantiate(CubeTest);
    }

    private void Sphere()
    {
        Debug.Log("test");
        Instantiate(SphereTest);
    }
}
