using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Um : MonoBehaviour {



    public static Um instance;
    public GameObject kutpan;
    public GameObject gopan;
    public GameObject taptxt;
    public Text hms;
    public Text score;
    public Text hs1;
    public Text hs2;
    // Use this for initialization

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    void Start () {
        hs1.text = "Highscore : "+PlayerPrefs.GetInt("hs").ToString();
      
    }
	public void Gamestart()
    {
       
        taptxt.SetActive(false);
        kutpan.GetComponent<Animator>().Play("panel");
        hms.GetComponent<Animator>().Play("hms");
        

    }
    public void Gameover()
    {
        score.text = PlayerPrefs.GetInt("score").ToString();
        hs2.text = PlayerPrefs.GetInt("hs").ToString();
        gopan.SetActive(true);
    }
    public void Reset()
    {
        SceneManager.LoadScene(0);
    }
    // Update is called once per frame
    void Update () {
       
    }
}
