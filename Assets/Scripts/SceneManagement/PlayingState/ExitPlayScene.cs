using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitPlayScene : MonoBehaviour
{
    [Header("Variables")]
    public KeyCode escape = KeyCode.Escape;

    public void Update()
    {
        if(Input.GetKeyUp(KeyCode.Escape))
        {
            SceneLoader.Load(SceneLoader.Scene.StartScreenScene);
        }
    }
}
