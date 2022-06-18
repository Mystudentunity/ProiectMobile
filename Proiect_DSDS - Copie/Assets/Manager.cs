using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{
    public void Scene()
    {
        if (SceneManager.GetActiveScene().name == "Home")
            SceneManager.LoadScene("Play");
        else
            SceneManager.LoadScene("Home");

        DontDestroyOnLoad(this);
    }
}
