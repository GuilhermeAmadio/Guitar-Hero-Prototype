using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButton : MonoBehaviour
{
    [SerializeField] private StringSO sceneToLoad;

    public void LoadScene()
    {
        SceneManager.LoadScene(sceneToLoad.GetString());
    }

    public void SetString(string s)
    {
        sceneToLoad.SetString(s);
    }
}
