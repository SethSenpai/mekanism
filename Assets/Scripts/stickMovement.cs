using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stickMovement : MonoBehaviour {

    public GameObject leftIk;
    public GameObject rightIk;
    public float speed = 1;
    private float sinAmp = 10;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //Debug.Log(Input.GetAxis("HorizontalRight"));
        float l = Input.GetAxis("HorizontalRight");
        //float r = Input.GetAxis("HorizontalRight");
        if (l > 0)
        {
            this.transform.position = this.transform.position + new Vector3(Mathf.Pow(l * 10, speed) * Time.deltaTime,0,0);
        }

        if(l < 0)
        {
            this.transform.position = this.transform.position - new Vector3(Mathf.Pow(Mathf.Abs(l) * 10, speed) * Time.deltaTime, 0, 0);
        }
    }
}
