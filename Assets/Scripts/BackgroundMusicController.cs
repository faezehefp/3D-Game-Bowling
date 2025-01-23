using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class BackgroundMusicController : MonoBehaviour
{
    [SerializeField] private Sprite soundOnIcon;
    [SerializeField] private Sprite soundOffIcon;
    [SerializeField] private Button buttonSoundIcon;

    [SerializeField] private AudioSource backgroundMusic;
    private bool isOn=true;
    // Start is called before the first frame update
    void Start()
    {
        soundOnIcon=buttonSoundIcon.image.sprite;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ButtonClicked()
    {
        if(isOn)
        {
            buttonSoundIcon.image.sprite=soundOffIcon;
            isOn=false;
            backgroundMusic.mute=true;
        }
        else
        {
            buttonSoundIcon.image.sprite=soundOnIcon;
            isOn=true;
            backgroundMusic.mute=false;
        }

    }
}
