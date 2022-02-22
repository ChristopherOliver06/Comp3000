using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class HandPresence : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        List<InputDevice> devices = new List<InputDevice>();
        InputDevices.GetDevices(devices);

      //  foreach (var item in collection)//
        {
           // Debug.Log(item)//
        }//
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
