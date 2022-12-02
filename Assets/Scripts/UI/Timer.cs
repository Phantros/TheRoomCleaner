using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    [Header("References")]
    public TextMeshProUGUI timer;

    [Header("Variables")]
    public float minigameLength;


    private void Update()
    {
        minigameLength -= 1 * Time.deltaTime;
        timer.text = minigameLength.ToString();

        if(minigameLength <= 0)
        {
            SceneLoader.Load(SceneLoader.Scene.EndScreenScene);
        }
    }
}
