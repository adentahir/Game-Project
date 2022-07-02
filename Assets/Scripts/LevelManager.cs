using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class LevelManager : MonoBehaviour
{

    [SerializeField]
    public List<GameObject> levels;

    [SerializeField]
    public List<GameObject> ImageList;
    
   
    public static bool[] levelCom = new bool[5];


  


    public static LevelManager instance;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;

        }
        else if (instance != this)
        { }

        DontDestroyOnLoad(gameObject);
    }
    private void Start()
    {
        if (!PlayerPrefs.HasKey("Level1"))
            {
            PlayerPrefs.SetInt("Level1", 0);
            PlayerPrefs.SetInt("Level2", 0);
            PlayerPrefs.SetInt("Level3", 0);
            PlayerPrefs.SetInt("Level4", 0);
        }
        else
        {
            Reload2();
        }

        Reload();
       
        
    }

    private void OnEnable()
    {
        if(PlayerPrefs.HasKey("Level1"))
        {
            Reload2();
        }
    }



    public void LoadLevel(int i)
    {
        SceneManager.LoadScene(i);
    }

    public void Reload()
    {
     
        for (int i = 0; i < 4; i++)
        {
            string _level = "Level";
            var _index = PlayerPrefs.GetInt(_level + i.ToString());
            if (_index == 1)
            {
                levels[i].GetComponent<Button>().interactable = true;
                ImageList[i].gameObject.SetActive(true);
                levelCom[i] = true;
            }
        }
    }
    public void Reload2()
    {
        for (int i = 0; i < 4; i++)
        {

            if (levelCom[i])
            {
                levels[i].GetComponent<Button>().interactable = true;
                ImageList[i].gameObject.SetActive(true);
            
            }
        }
    }



}





