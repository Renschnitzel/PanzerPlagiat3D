using UnityEngine;
using System.Collections;

public class ProjektilController : MonoBehaviour {
	public float movementSpeed;
	public float flyDistance;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
		this.transform.Translate (0.0f, movementSpeed*Time.deltaTime, 0.0f);
		if(transform.position.y > flyDistance){
			DestroyImmediate(this);
		}
	}
}
