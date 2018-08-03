using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platformspawn : MonoBehaviour {
    
        public GameObject platform;
    public GameObject diamond;

    Vector3 lp;
        float size;
    public bool gover =false;
        // Use this for initialization
        void Start()
        {
            lp = platform.transform.position;
            size = platform.transform.localScale.x;
       /*for (int i = 0; i < 10; i++)
        {
            Spawnplat();
           
        }*/
       
        }
    public void Startspawn()
    {
        InvokeRepeating("Spawnplat", 0.1f, 0.2f);
    }
        // Update is called once per frame
        void Update()
        {
        if ((GameObject.Find("Ball").GetComponent<BallController>().go) == true)
        {
            CancelInvoke("Spawnplat");
        }
    }
    void Spawnplat()
    {
       
       
        int rand=Random.Range(0,6);
        if (rand < 3)
        {
            Spawnx();
;        }
        else if(rand>=3)
        {
            Spawnz();
        }
    }
        void Spawnx()
        {
            Vector3 pos = lp;
            pos.x += size;
            lp = pos;
            Instantiate(platform, pos, Quaternion.identity); 
        int rand = Random.Range(0, 4);
        if (rand < 1)
        {
            Instantiate(diamond, new Vector3(pos.x,pos.y+1,pos.z), diamond.transform.rotation);
        }
        
        }
        void Spawnz()
        {

        Vector3 pos = lp;
        pos.z += size;
        lp = pos;
        Instantiate(platform, pos, Quaternion.identity);
        int rand = Random.Range(0, 4);
        if (rand < 1)
        {
            Instantiate(diamond, new Vector3(pos.x, pos.y + 1, pos.z), diamond.transform.rotation);
        }
    }
    }
