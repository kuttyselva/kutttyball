using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour {
    public static BallController instance;
    public GameObject particle;
  
    [SerializeField]
    private bool started;
    public float speed;
    public int score;
    Rigidbody rb;
  
    public bool go;
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    // Use this for initialization
    void Start () {

        started = false;
        go = false;
	}
	
	// Update is called once per frame
	void Update () {
        if (!started)
        {
            if (Input.GetMouseButtonDown(0))
            {
                rb.velocity = new Vector3(speed, 0, 0);
                started = true;
                Gm.instance.Startgame();
             
            }
        }
        if(!Physics.Raycast(transform.position, Vector3.down,1f))
        {
            go = true;
            rb.velocity = new Vector3(0,-25f, 0);
            Camera.main.GetComponent<Camerafall>().govr = true;
            Gm.instance.Gameover();
        }
        if (Input.GetMouseButtonDown(0) && !go)
        {
            SwitchDirection();
        }
        if (score == 70)
        {
            speed += 0.01f;
        }
        if (score == 50)
        {
            speed += 0.01f;
        }
        if (score == 30)
        {
            speed += 0.01f;
        }
    }
    void SwitchDirection()
    {
if(rb.velocity.z > 0)
        {
            rb.velocity = new Vector3(speed, 0, 0);
        }
        else if(rb.velocity.x>0)
        {
            rb.velocity = new Vector3(0, 0, speed);
        }
    }
    public void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Diamond")
        {
            score += 1;
            GameObject part= Instantiate(particle, col.gameObject.transform.position, Quaternion.identity);
           
            Destroy(col.gameObject);
            Destroy(part, 1f);
           
        }
    }
}
