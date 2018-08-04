using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gm : MonoBehaviour {
    public static Gm instance;
    public bool gameover;
  
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    // Use this for initialization
    void Start () {
        gameover = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void Startgame()
    {
        Um.instance.Gamestart();

        Sm.instance.Startscore();
        
        GameObject.Find("Platforms").GetComponent<Platformspawn>().Startspawn();

    }
    public void Gameover()
    {
        Um.instance.Gameover();
        Sm.instance.Stopscore();
        gameover = true;
    }
}
