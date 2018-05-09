using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerMovement : MonoBehaviour {

    public GameObject leftIk;
    public GameObject rightIk;
    public float speed = 1;
    private float sinAmp = 10;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //Debug.Log(Input.GetAxis("TriggerLeft") + "," + Input.GetAxis("TriggerRight"));
        float l = Input.GetAxis("TriggerLeft");
        float r = Input.GetAxis("TriggerRight");
        if (l > 0)
        {
            this.transform.position = this.transform.position - new Vector3(Mathf.Pow(l * 10, speed) * Time.deltaTime,0,0);
        }

        if(r > 0)
        {
            this.transform.position = this.transform.position + new Vector3(Mathf.Pow(r * 10, speed) * Time.deltaTime, 0, 0);
        }
    }
}
