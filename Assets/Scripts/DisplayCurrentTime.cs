using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayCurrentTime : MonoBehaviour
{
    public GameObject displayText;
    //public float hour;
    //public float minute;

    void Update()
    {
        /*hour = System.DateTime.Now.Hour;
        minute = System.DateTime.Now.Minute;*/
        displayText.GetComponent<Text>().text = DateTime.Now.ToString("HH:mm");
    }
}
