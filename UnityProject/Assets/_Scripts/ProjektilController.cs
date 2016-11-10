using UnityEngine;
using System.Collections;

public class ProjektilController : MonoBehaviour {
	public float movementSpeed;
	//public float flyDistance;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.Translate (0.0f, movementSpeed*Time.deltaTime, 0.0f);
		/*
		 * Wurde zum Schussspawner verschoben und somit obsolet
		if(transform.position.y > flyDistance){
			Destroy(GetComponent<CapsuleCollider>());
		}
		*/
	}
}
