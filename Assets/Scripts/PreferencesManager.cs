using UnityEngine;

public static class PreferencesManager
{
    // gets the music volume to set it later on.
    public static float GetMusicVolume()
    {
        return PlayerPrefs.GetFloat("Music Volume", 1);

    }

    // gets the master volume to set it later on.
    public static float GetMasterVolume()
    {
        return PlayerPrefs.GetFloat("MasterVolume", 1);
    }

    // sets the music volume in the player prefabs
    public static void SetMusicVolume(float soundLevel)
    {
        PlayerPrefs.SetFloat("MusicVolume", soundLevel);
    }
    // sets the master volume in the player prefabs
    public static void SetMasterVolume(float soundLevel)
    {
        PlayerPrefs.SetFloat("MasterVolume", soundLevel);
    }
}
