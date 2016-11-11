using UnityEngine;
using System.Collections;

public class ProjektilController : MonoBehaviour {
	public float movementSpeed;
	public GameObject explosion;

	void Start () {
		this.Destroy(gameObject, 10.0f);//entspricht etwa 10 sekunden
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.Translate (0.0f, movementSpeed * Time.deltaTime, 0.0f);


	}
	void OnTriggerEnter(Collider coll){
		Destroy(Instantiate (explosion, transform.position, transform.rotation), 3.0f);
		this.Destroy(gameObject);

	}

}
