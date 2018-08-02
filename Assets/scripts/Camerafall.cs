using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camerafall : MonoBehaviour {
    public GameObject ball;
    Vector3 offset;
    public float lrate;
    public bool govr;
	// Use this for initialization
	void Start () {
        offset = ball.transform.position - transform.position;
        govr = false;
	}
	
	// Update is called once per frame
	void Update () {
        if (!govr)
        {
            Follow();
        }
	}

    void Follow()
    {
        Vector3 pos = transform.position;
        Vector3 target = ball.transform.position-offset;
        pos=Vector3.Lerp(pos, target, lrate * Time.deltaTime);
        transform.position = pos;
    }



}
