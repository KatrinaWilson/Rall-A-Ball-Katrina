using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderUpdate : MonoBehaviour
{
    public Slider targetRotationSlider;
    public Text targetRotationSpeed;
    public static float TargetRotationSpeed;

    public Slider ballSpeedSlider;
    public Text ballSpeed;
    public static float BallSpeed;
    // Update is called once per frame
    void Update()
    {
        TargetRotationSpeed = targetRotationSlider.value;
        targetRotationSpeed.text = "Rotation: " + TargetRotationSpeed;

        BallSpeed = ballSpeedSlider.value;
        ballSpeed.text = "Ball Speed: " + BallSpeed;
    }
}
