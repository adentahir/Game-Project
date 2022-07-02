using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Level : MonoBehaviour
{
    // parameters
    [SerializeField] int breakableBlocks; // Serialized for debugging purposes

    // cached reference
    //SceneLoader sceneloader;

    private void Start()
    {
        //sceneloader = FindObjectOfType<SceneLoader>();
    }

    public void CountBlocks()
    {
        breakableBlocks++;
    }
    public void BlockDestroyed()
    {
        breakableBlocks--;
        if(breakableBlocks<=0)
        {
           
            var s = SceneManager.GetActiveScene().buildIndex;
            Debug.Log(s);
            LevelManager.levelCom[s-2] = true;
            PlayerPrefs.SetInt("Level" + (s-2).ToString(), 1);
            PlayerPrefs.Save();
            SceneManager.LoadScene(s + 1);

        }
    }


}
