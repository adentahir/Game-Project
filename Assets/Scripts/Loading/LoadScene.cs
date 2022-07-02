using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LoadScene : MonoBehaviour
{
  public void loadSceneLevel()
    {
        SceneManager.LoadScene("LevelScene");
    }

    public void Quit()
    {
        Application.Quit();
    }

}
