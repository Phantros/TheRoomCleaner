using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartButtonBehaviour : MonoBehaviour
{
    [Header("References")]
    public Button _startButton;

    private void Awake()
    {
        Cursor.lockState = CursorLockMode.None;

        Button startButton = _startButton.GetComponent<Button>();
        startButton.onClick.AddListener(Play);
    }

    void Play() => SceneLoader.Load(SceneLoader.Scene.PlayingStateScene);
}
