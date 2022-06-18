using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mute : MonoBehaviour
{
    public Sprite[] sprites;
    public AudioSource sound;
    public Image image;

    private void Start()
    {
        if (PlayerPrefs.GetInt("audioSound") == 0)
        {
            sound.Stop();
            image.sprite = sprites[1];
            PlayerPrefs.SetInt("audioSound", 0);
        }
        else
        {
            sound.Play();
            image.sprite = sprites[0];
            PlayerPrefs.SetInt("audioSound", 1);
        }
    }
    public void MuteUnmute()
    {
        if(sound.isPlaying)
        {
            sound.Stop();
            image.sprite = sprites[1];
            PlayerPrefs.SetInt("audioSound", 0);
        }
        else
        {
            sound.Play();
            image.sprite = sprites[0];
            PlayerPrefs.SetInt("audioSound", 1);
        }

        
    }
}
