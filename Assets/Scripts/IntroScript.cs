using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class IntroScript : MonoBehaviour
{

    public VideoPlayer videoPlayer;
    public GameObject introCanvas;
    public GameObject mainCanvas;

    void Start() {
        videoPlayer.loopPointReached += LoadMainCanvas;
    }

    void Update() {
        if (Input.GetButtonDown("KeyboardKeys") || (Input.GetButtonDown("Jump"))) {
            videoPlayer.frame = 1005;
        }
    }

    void LoadMainCanvas(UnityEngine.Video.VideoPlayer vp) {
        introCanvas.SetActive(false);
        mainCanvas.SetActive(true);
        this.gameObject.SetActive(false);
  
    }
}
