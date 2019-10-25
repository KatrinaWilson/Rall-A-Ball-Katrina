using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;// added

//attached to data manager object in all scenes

public class keepData : MonoBehaviour
{
    public static string PlayerName = "New Player"; 
    public static int PlayerLives;
    public static int PlayerScore;// link to the old game somehow?
    public static int HighScore = 0;
    public static float PlayerSpeed = 0;
    public static int RoundsPlayed;
    public static float TargetSpeed = 0;

    public InputField PlayerNameInput;
    public Slider PlayerSpeedSlider;
    public Dropdown PlayerLivesDropdown;
    public Slider TargetSpeedSlider;
    // don't forget to fill these fields in the inspector for data manager

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject); //don't destroy when new scene is loaded
    }

    public void UpdateName()
    {
        PlayerName = PlayerNameInput.text;
    }
    public void SetLives()
    {
        PlayerLives = PlayerLivesDropdown.value;
    }
    public void ChangeSpeed()
    {
        PlayerSpeed = PlayerSpeedSlider.value;
    }

    public void ChangeTargetSpeed()
    {
        TargetSpeed = TargetSpeedSlider.value;
    }

    public void keepScore()
    {
        PlayerScore = PlayerController.count;
    }

}