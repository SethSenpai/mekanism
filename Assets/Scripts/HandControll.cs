using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandControll : MonoBehaviour {

    private Vector3 savedPos;
    public bool leftHand = false;
    public float multiplier = 5;
    public float maxDistance = 1;

    // Use this for initialization
    void Start () {
        savedPos = transform.position;
	}
	
	// Update is called once per frame
	void Update () {

        if (leftHand)
        {

            Vector2 contPos = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
            Vector2 outputPos = GetConstrainedPosition(new Vector2(0, 0),contPos);
            Vector3 clampedPos = new Vector3(outputPos.x, outputPos.y, 0);
            this.transform.position = savedPos + clampedPos; 
        }
        else
        {
            Vector2 contPos = new Vector2(Input.GetAxis("HorizontalRight"), Input.GetAxis("VerticalRight"));
            Vector2 outputPos = GetConstrainedPosition(new Vector2(0, 0), contPos);
            Vector3 clampedPos = new Vector3(outputPos.x, outputPos.y, 0);
            this.transform.position = savedPos + clampedPos;
        }
	}

    Vector2 GetConstrainedPosition(Vector2 midPoint, Vector2 endPoint)
    {
        //get the length of the line
        float dist = Vector2.Distance(midPoint, endPoint);

        //Check for max length
        if (Vector2.Distance(midPoint, endPoint) > maxDistance)
        {
            //get the direction of the line between mid point and end point
            Vector2 dirVector = endPoint - midPoint;

            //normalize
            dirVector.Normalize();
            //Debug.Log((dirVector * maxDistance) + midPoint);
            //return the clamped position
            return (dirVector * maxDistance) + midPoint;
            
        }
        //return the original position
        return endPoint;
    }
}
