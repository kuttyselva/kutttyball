using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Sm : MonoBehaviour {
    public static Sm instance;
    public int score;
    public int hs;
    public Text hms;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    // Use this for initialization
    void Start () {
        score = 0;
        PlayerPrefs.SetInt("score", score);

	}
	
	// Update is called once per frame
	void Update () {
       
    }
    void Incscore()
    {
        score = GameObject.Find("Ball").GetComponent<BallController>().score;
        
        PlayerPrefs.SetInt("score", score);
        hms.text = "score : " +score;


    }
    public void Startscore()
    {
       
        InvokeRepeating("Incscore", 0.1f, 0.001f);
        

       
    }
    public void Stopscore()
    {
        CancelInvoke("Incscore");
        PlayerPrefs.SetInt("score", score);
        if (PlayerPrefs.HasKey("hs"))
        {
            if (score > PlayerPrefs.GetInt("hs"))
            {
                PlayerPrefs.SetInt("hs", score);
            }
        }
        else
        {
            PlayerPrefs.SetInt("hs", score);
        }
    }
}
