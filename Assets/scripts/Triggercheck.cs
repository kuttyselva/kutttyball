using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triggercheck : MonoBehaviour {
   
    // Use this for initialization
    void Start () {
      
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Ball")
        {
            Invoke("Falldown", 0.5f);
           
           
        }
    }
    void Falldown()
    {
        GetComponentInParent<Rigidbody>().useGravity = true;
        GetComponentInParent<Rigidbody>().isKinematic = false;
        Destroy(transform.parent.gameObject,2f);
    }
}
