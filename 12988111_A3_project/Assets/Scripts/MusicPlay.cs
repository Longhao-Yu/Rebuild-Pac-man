using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicPlay : MonoBehaviour
{
    private AudioSource music;
    Button iButton;
    void Awake()
    {
        GameObject menuMusic = GameObject.Find("menuBGM");
        music = menuMusic.GetComponent<AudioSource>();
        music.Play();
    }

    // Start is called before the first frame update
    void Start()
    {
        GameObject mButton = GameObject.Find("Canvas/AudioPlay");
        iButton = mButton.GetComponent<Button>();
    }

    // Update is called once per frame
    public void OnMouseDown()
    {
        AudioStart();
    }
    public void AudioStart()
    {
        if (music.isPlaying)
        {
            music.Stop();
            iButton.image.sprite = Resources.Load<Sprite>("musicOFF");
        }
        else
        {
            music.Play();
            iButton.image.sprite = Resources.Load<Sprite>("musicON");
        }
    }
}
