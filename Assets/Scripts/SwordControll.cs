using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordControll : MonoBehaviour {

    private Vector3 savedPos;
    public float multiplier = 5;

	// Use this for initialization
	void Start () {
        savedPos = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.position = savedPos + new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0) * multiplier;
	}
}
