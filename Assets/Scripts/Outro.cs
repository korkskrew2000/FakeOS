using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class Outro : MonoBehaviour
{
    public VideoPlayer videoPlayer;


    void Start() {
        videoPlayer.loopPointReached += Exit;
    }


    void Exit(UnityEngine.Video.VideoPlayer vp) {
        Application.Quit();
    }
}
