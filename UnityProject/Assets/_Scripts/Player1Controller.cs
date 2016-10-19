using UnityEngine;
using System.Collections;

public class Player1Controller : MonoBehaviour {
	public float moveSpeed;
	public float rotateSpeed;
	public float cameraSpeed;
	public Camera cam;
	public GameObject rohr;
	public GameObject mündung;
	public GameObject schuss;

	private Rigidbody rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void LateUpdate () {
		//Iput auslesen
		float movZ = Input.GetAxis ("P1LSVertical") * Time.deltaTime * moveSpeed;
		float rotY = Input.GetAxis ("P1LSHorizontal") * Time.deltaTime * rotateSpeed;
		float cRotY = Input.GetAxis ("P1RSHorizontal") * Time.deltaTime * cameraSpeed;
		float cRotX = Input.GetAxis ("P1RSVertical") * Time.deltaTime * cameraSpeed;
		//Input anwenden
		rb.transform.Translate (0.0f, 0.0f, movZ);
		rb.transform.Rotate (0.0f, rotY, 0.0f);
		rohr.transform.Rotate (0.0f, -rotY, 0.0f);
		//Camera anpassen
		cam.transform.position=this.transform.position;
		cam.transform.Rotate (cRotX, 0.0f, 0.0f, Space.Self);
		cam.transform.Rotate (0.0f, cRotY, 0.0f, Space.World);
		cam.transform.Translate(0.0f, 2.5f, -3.0f, Space.Self);
		//Rohr ausrichen, höhöhöh
		rohr.transform.Rotate(0.0f, cRotY, 0.0f, Space.Self);
		//Schiesen
		/*
		if(Input.GetButton("Fire1")){
			Instantiate (schuss, mündung.transform.position, mündung.transform.rotation);
		}
		*/
	}

}
