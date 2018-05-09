using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TwoHandTracker : MonoBehaviour {

    public GameObject otherHand;

    // Use this for initialization
    void Start () {
                
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.position = otherHand.transform.position;
        this.transform.rotation = otherHand.transform.rotation;
	}
}
