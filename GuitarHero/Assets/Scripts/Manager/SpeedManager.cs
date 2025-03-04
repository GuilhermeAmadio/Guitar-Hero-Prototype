using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedManager : MonoBehaviour
{
    [SerializeField] private AudioSource music;

    public void ChangeGameSpeed(float newTime)
    {
        Time.timeScale = newTime;
        music.pitch = newTime;
    }
}
