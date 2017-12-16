using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControleCamera : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float velX = -Input.GetAxis("Vertical");
		float velY = Input.GetAxis("Horizontal");
		Vector3 rotacao = transform.eulerAngles;
		transform.eulerAngles = rotacao + new Vector3 (velX, velY, 0f);
	}
}
