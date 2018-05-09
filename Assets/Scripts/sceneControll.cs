using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class sceneControll : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyUp("1"))
        {
            Debug.Log("loading Fist Test");
            SceneManager.LoadScene("fistTest");
        }
        if (Input.GetKeyUp("2"))
        {
            Debug.Log("loading Sword Test");
            SceneManager.LoadScene("swordTest");
        }
        if (Input.GetKeyUp("3"))
        {
            Debug.Log("loading Sword Test 2");
            SceneManager.LoadScene("swordTest2");
        }
    }
}
