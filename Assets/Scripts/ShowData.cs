using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowData : MonoBehaviour
{
    public Text TargetRotationText;
    public Text BallSpeedText;
    public Text RoundsText;
    public Text NameText;
    public Text HighScoreText;
    public Text ScoreText;

    private void Awake()
    {
        TargetRotationText.text = "Rotation: " + SliderUpdate.TargetRotationSpeed;
        BallSpeedText.text = "Ball Speed: " + SliderUpdate.BallSpeed;
        RoundsText.text = "Rounds: " + keepData.PlayerLives.ToString();
        NameText.text = "Player: " + keepData.PlayerName;
        HighScoreText.text = "High Score: " + keepData.HighScore.ToString();
        ScoreText.text = "Score: " + keepData.PlayerScore;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
