using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows.Speech;
using System.Linq;

public class AllyCommands : MonoBehaviour

{
    public GameObject AttackCommand;
    public GameObject DefenceCommand;
    public GameObject FireBallCommand;
    public GameObject IceBlastCommand;
    public GameObject ThunderSlapCommand;
    public GameObject BarrierCommand;
    public GameObject MagicBarrierCommand;
    public GameObject HealCommand;
    public GameObject AntigenCommand;

    private KeywordRecognizer allyCommandKeyword;
    private Dictionary<string, Action> actions = new Dictionary<string, Action>();


    private void Start()
    {


        allyCommandKeyword = new KeywordRecognizer(actions.Keys.ToArray());
        allyCommandKeyword.OnPhraseRecognized += SpeechDetected;
        allyCommandKeyword.Start();
    }


    private void SpeechDetected(PhraseRecognizedEventArgs speech)

    {
        Debug.Log(speech.text);

        actions[speech.text].Invoke();

    }


    private void Attack()
    {
        Debug.Log("test");

        Instantiate(AttackCommand);

    }

    private void Defence()
    {
        Debug.Log("test");

        Instantiate(DefenceCommand);

    }


    private void FireBall()
    {
        Debug.Log("test");

        Instantiate(FireBallCommand);

    }

    private void IceBlast()
    {
        Debug.Log("test");

        Instantiate(IceBlastCommand);

    }

    private void ThunderSlap()
    {
        Debug.Log("test");

        Instantiate(ThunderSlapCommand);

    }
    private void Barrier()
    {
        Debug.Log("test");

        Instantiate(BarrierCommand);

    }

    private void MagicBarrier()
    {
        Debug.Log("test");

        Instantiate(MagicBarrierCommand);

    }
    private void Heal()
    {
        Debug.Log("test");

        Instantiate(HealCommand);

    }

    private void Antigen()
    {
        Debug.Log("test");

        Instantiate(AntigenCommand);

    }

}