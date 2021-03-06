﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SoundManagement;

public class Example : MonoBehaviour
{
    void OnGUI()
    {
        if (GUI.Button(new Rect(10, 10, 150, 30), "Play SE1"))
        {
            SoundManager.Instance.Play(0);
        }
        if (GUI.Button(new Rect(10, 50, 150, 30), "Play SE2"))
        {
            SoundManager.Instance.Play(1);
        }
        if (GUI.Button(new Rect(10, 90, 150, 30), "Play SE3"))
        {
            SoundManager.Instance.Play(2);
        }


        if (GUI.Button(new Rect(10, 130, 150, 30), "Play BGM1"))
        {
            SoundManager.Instance.PlayBgm(0);
        }
        if (GUI.Button(new Rect(10, 170, 150, 30), "Play BGM2"))
        {
            SoundManager.Instance.PlayBgm(1);
        }
    }
}
