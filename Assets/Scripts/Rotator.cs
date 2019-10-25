using UnityEngine;
using System.Collections;

public class Rotator : MonoBehaviour
{
    void Update()
    {
        float m = SliderUpdate.TargetRotationSpeed;
        transform.Rotate(new Vector3(m * 15, m * 30, m * 45) * Time.deltaTime);
    }

}