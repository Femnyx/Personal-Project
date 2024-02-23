using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsManager : MonoBehaviour
{
    public Slider musicSlider, masterSlider;

    // Start is called before the first frame update
    void Start()
    {
        if (masterSlider != null)
        {
            masterSlider.value = PreferencesManager.GetMasterVolume();
        }
        if (musicSlider != null)
        {
            musicSlider.value = PreferencesManager.GetMusicVolume();
        }
    }

    // allows you to change the sound volume.
    public void ChangeSoundVolume(float soundLevel)
    {
        AudioManager.Instance.ChangeSoundVolume(soundLevel);
    }
    // allows you to change music volume.
    public void ChangeMusicVolume(float soundLevel)
    {
        AudioManager.Instance.ChangeMusicVolume(soundLevel);
    }



}
