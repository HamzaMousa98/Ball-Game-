using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Setting : MonoBehaviour
{
    private Player player;
    private string DifficutLevel;
    private float SoundEffectsLevel;
    private float GameSoundLevel;
    private string NavigateWay;

    void Start()
    {

    }
    void Update()
    {

    }
    public void setDifficutLevel(string DifficutLevel)
    {
        this.DifficutLevel = DifficutLevel;
    }
    public string getDifficutLevel()
    {
        return DifficutLevel;
    }


    public void setSoundEffectsLevel(float SoundEffectsLevel)
    {
        this.SoundEffectsLevel = SoundEffectsLevel;
    }
    public float getSoundEffectsLevel()
    {
        return SoundEffectsLevel;
    }

    public void setGameSoundLevel(float GameSoundLevel)
    {
        this.GameSoundLevel = GameSoundLevel;
    }
    public float getGameSoundLevel()
    {
        return GameSoundLevel;
    }


    public void setControlWay(string Control)
    {
        NavigateWay = Control;
    }
    public string getControlWay()
    {
        return NavigateWay;
    }
}

