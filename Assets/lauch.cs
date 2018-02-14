using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class lauch : MonoBehaviour {

	float start = 0;

	// Use this for initialization
	void Start () {
		start = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time - start > 3f) {
			SceneManager.LoadScene (1);
		}
	}
}
