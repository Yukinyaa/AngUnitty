using UnityEngine;
using System.Collections;

public class studyScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.A)) 
		{
			float rnd = Random.Range(0.0f,0.5f);
			this.transform.position = new Vector3(0.0f,0.0f,rnd);
		}
		if (Input.GetKeyDown (KeyCode.B)) 
		{
			float rnd = Random.Range(0.0f,360.0f);
			this.transform.rotation = Quaternion.Euler(rnd,0.0f,0.0f);
		}
	}
}
