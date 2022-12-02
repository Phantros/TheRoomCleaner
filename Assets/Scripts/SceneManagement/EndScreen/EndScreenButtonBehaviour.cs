using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndScreenButtonBehaviour : MonoBehaviour
{
    [Header("References")]
    public Button _playAgainButton;
    public Button _backToMainButton;

    private void Awake()
    {
        Cursor.lockState = CursorLockMode.None;

        Button playAgain = _playAgainButton.GetComponent<Button>();
        Button backToMain = _backToMainButton.GetComponent<Button>();

        playAgain.onClick.AddListener(PlayAgain);
        backToMain.onClick.AddListener(BackToMain);
    }

    void PlayAgain()
    {
        SceneLoader.Load(SceneLoader.Scene.PlayingStateScene);
    }

    void BackToMain()
    {
        SceneLoader.Load(SceneLoader.Scene.StartScreenScene);
    }
}
