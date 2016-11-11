using UnityEngine;
using System.Collections;

public class SchussSpawner : MonoBehaviour {
	public GameObject schuss;
	public float shootFrequency;

	private float time;
	private float nextShot;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		time = time+Time.deltaTime;
		if(Input.GetButton("Fire1") && time>nextShot){
			nextShot = time + shootFrequency;
			nextShot = nextShot - time;
			time = 0.0f;

			Instantiate (schuss, transform.position, transform.rotation);
		}
	}
}
