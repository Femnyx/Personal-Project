using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[System.Serializable]
public class PlayerData
{
    public int highscore;


    public PlayerData(ScoreManager player)
    {
        highscore = player.highscore;
    }

}
