using UnityEngine;
using System.Collections;

public class ProjektilController : MonoBehaviour {
	public float movementSpeed;
	public GameObject explosion;
	public AudioClip explosionSfx;

	private AudioSource audio;
	void Start () {
		this.Destroy(gameObject, 10.0f);//entspricht etwa 10 sekunden
		audio=this.GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.Translate (0.0f, movementSpeed * Time.deltaTime, 0.0f);


	}
	void OnTriggerEnter(Collider coll){
		Destroy(Instantiate (explosion, transform.position, transform.rotation), 3.0f);
		audio.PlayOneShot(explosionSfx, 0.8f);
		audio.clip = explosionSfx;
		audio.Play ();
		transform.position= new Vector3(0.0f, -10.0f, 0.0f);

	}

}
