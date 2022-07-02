////using System.Collections;
////using System.Collections.Generic;
////using UnityEngine;
////using UnityEngine.UI;
////public class Leaderboard : MonoBehaviour
////{
////  public Text[] _Text;
////    // public LevelManager instance;
////    private void Awake()
////    {
////        InitParams();
////    }
////    void Start()
////    {
       
////        CheckHighScore();
////    }


////    #region Init
////    public void InitParams()
////    {
////        if (PlayerPrefs.HasKey("ReSession"))
////        {
////            for (int i = 0; i < 5; i++)
////            {
////                string _level = "Level";
////                var _index = PlayerPrefs.GetInt(_level + i.ToString());
////                if (_index == 1)
////                {
////                    LevelManager.levelCom[i] = true;
////                }
////            }
////            for (int i = 0; i < 5; i++)
////            {
////                if (LevelManager.levelCom[i])
////                {
////                    var s = (i + 1).ToString();
////                    _Text[i].text = ReturnAfterConverting(PlayerPrefs.GetFloat("Time" + s));
////                    LevelManager.highscore[i] = PlayerPrefs.GetFloat("Time" + s);
////                }
////                else
////                {
////                    _Text[i].text = "-";
////                }
////            }
////        }
////        else
////        {
////            PlayerPrefs.SetInt("ReSession", 1);
////            for (int i = 1; i < 6; i++)
////            {
////                PlayerPrefs.SetFloat("Time" + i.ToString(), 0);
////            }
////            PlayerPrefs.Save();
////            foreach(Text t in _Text)
////            {
////                t.text = "-";
////            }
////        }
////    }  
    


////    public void CheckHighScore()
////    {
////         for (int i = 0; i < 5; i++)
////            {
////                if (LevelManager.levelCom[i])
////                {
////                    _Text[i].text = ReturnAfterConverting(LevelManager.highscore[i]);
////                }
////                else
////                {
////                    _Text[i].text = "-";
////                }
////            }
////    }

////    #endregion
////    public string ReturnAfterConverting(float totalTime)
////    {
////        var ts = System.TimeSpan.FromSeconds(totalTime);
////        string a = string.Format("{0:00}:{1:00}", ts.Minutes, ts.Seconds);
////        return a;
////    }

////}
