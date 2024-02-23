 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{
    private static AudioManager instance;

    public static AudioManager Instance { get { return instance; } }

    public AudioMixer masterMixer;

    public Slider musicSlider, masterSlider;

    private void Awake()
    {
        // destroys the game object if it meets the requirements.
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            instance = this;
        }
        DontDestroyOnLoad(this.gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
       // sets a true false statement for MasterVol and MusicVol in the Master Mixer in the unity project.
       masterMixer.SetFloat("MasterVol", PreferencesManager.GetMasterVolume());
       masterMixer.SetFloat("MusicVol", PreferencesManager.GetMusicVolume());

        if(masterMixer != null)
            PreferencesManager.GetMasterVolume();

        if(musicSlider != null)
            PreferencesManager.GetMusicVolume();
    }

    // allows you to change the sound volume
    public void ChangeSoundVolume(float soundLevel)
    {
        masterMixer.SetFloat("MasterVol", soundLevel);
        PreferencesManager.SetMasterVolume(soundLevel);
    }

    //allows you to change the music volume
    public void ChangeMusicVolume(float soundLevel)
    {
        masterMixer.SetFloat("MusicVol", soundLevel);
        PreferencesManager.SetMusicVolume(soundLevel);
    }
}
