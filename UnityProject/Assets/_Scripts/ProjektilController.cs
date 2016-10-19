using UnityEngine;
using System.Collections;

public class ProjektilController : MonoBehaviour {
	public float movementSpeed;

	// Use this for initialization
	void Start () {
		/*
		this.transform.position = mündung.transform.position;
		this.transform.rotation = mündung.transform.rotation;
		*/
	}
	
	// Update is called once per frame
	void Update () {
		
		this.transform.Translate (0.0f, movementSpeed*Time.deltaTime, 0.0f);
	}
}
