using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public short SceneNumber;
    public int MaxFPS;
    public KeyCode KeyCode;

    void Start()
    {
        Application.targetFrameRate = MaxFPS;
    }

    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode))
        {
            SceneManager.LoadScene(SceneNumber);
        }
    }

    public void LoadScene(int sceneNumber)
    {
        SceneManager.LoadScene(sceneNumber);
    }
}
