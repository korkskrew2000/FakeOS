using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomKeySound : MonoBehaviour
{

    public AudioClip[] keySounds;
    public AudioClip[] spaceBarSounds;
    public AudioClip[] mouseClickSounds;
    public AudioSource source;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("KeyboardKeys")) {
            PlayKeySound();
        }

        if (Input.GetKeyDown("space")) {
            PlaySpaceSound();
        }

        if (Input.GetButtonDown("MouseClick")) {
            PlayMouseSound();
        }
    }

    public void PlayKeySound() {
        int selection = Random.Range(0, keySounds.Length);
        source.PlayOneShot(keySounds[selection]);
    }

    public void PlaySpaceSound() {
        int selection2 = Random.Range(0, spaceBarSounds.Length);
        source.PlayOneShot(spaceBarSounds[selection2]);
    }

    public void PlayMouseSound() {
        int selection3 = Random.Range(0, mouseClickSounds.Length);
        source.PlayOneShot(mouseClickSounds[selection3]);
    }
}
