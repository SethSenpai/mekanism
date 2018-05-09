using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordControll : MonoBehaviour {

    private Vector3 savedPos;
    public float multiplier = 5;
    private Vector3 rootPostition;
    public GameObject RootObject;
    public float maxDistance = 1;
    public bool clampToCircle = true;

	// Use this for initialization
	void Start () {
        savedPos = transform.position;
        rootPostition = RootObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 xOffset = new Vector3(0, 0, 0);

        if (rootPostition != RootObject.transform.position)
        {
            xOffset = RootObject.transform.position - rootPostition;
            rootPostition = RootObject.transform.position;
            savedPos = savedPos + xOffset;
        }

        if (clampToCircle)
        {
            Vector2 contPos = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
            Vector2 outputPos = GetConstrainedPosition(new Vector2(0, 0), contPos);
            Vector3 clampedPos = new Vector3(outputPos.x * multiplier, outputPos.y * multiplier, 0);
            this.transform.position = savedPos + clampedPos;
        }
        else
        {
            this.transform.position = savedPos + new Vector3(Input.GetAxis("Horizontal") * multiplier, Input.GetAxis("Vertical") * multiplier, 0);
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
