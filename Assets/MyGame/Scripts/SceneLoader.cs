using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour {

    enum Scenes { Scene0, Scene1};

    public void LoadNextScene()
    {
        SceneManager.LoadScene((int)Scenes.Scene1);
    }
}
