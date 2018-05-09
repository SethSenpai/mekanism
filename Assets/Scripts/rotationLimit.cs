using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotationLimit : MonoBehaviour {

    public float lower;
    public float upper;
    
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        Debug.Log(transform.eulerAngles.z);

		if(transform.eulerAngles.z < lower)
        {
            transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, lower);
        }

        if (transform.eulerAngles.z > upper)
        {
            transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, upper);
        }
    }
}
