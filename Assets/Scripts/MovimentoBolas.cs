using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentoBolas : MonoBehaviour {
	private Rigidbody rb;
	public float zOrig;
	public Vector3 velocidade = new Vector3(0f, 0f, 1f);

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
		rb.velocity = new Vector3(0f, 0f, 1f);
		zOrig = transform.position.z;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		transform.position = new Vector3(0f, 0f, zOrig + (transform.position.z - zOrig) % 1);
	}
}
