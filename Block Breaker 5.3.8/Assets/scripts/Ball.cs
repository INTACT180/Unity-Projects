﻿using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {

	bool primed = false;
	private Paddle paddle;
		
	private Vector3 paddleToBallVector;
	
	// Use this for initialization
	void Start () {
		paddle = GameObject.FindObjectOfType<Paddle>();
		paddleToBallVector = this.transform.position - paddle.transform.position;
		primed = true;
	}
	
	
	// Update is called once per frame
	void Update () {
		if(primed){
			if(Input.GetMouseButtonDown(0)){
				primed = false;
				this.GetComponent<Rigidbody2D>().velocity+= (new Vector2 (2f,10f));
			}
			this.transform.position = paddleToBallVector + paddle.transform.position;
		}
	}
	
	void OnCollisionEnter2D(Collision2D c) {
		int threshold = 13;
		Vector2 tweak = new Vector2();
	
		if(GetComponent<Rigidbody2D>().velocity.magnitude < threshold)
			tweak = new Vector2(
				Mathf.Sign(GetComponent<Rigidbody2D>().velocity.x) * Random.Range(0f,0.2f), 
				Mathf.Sign(GetComponent<Rigidbody2D>().velocity.y) * Random.Range(0f,0.2f));
		else if(GetComponent<Rigidbody2D>().velocity.magnitude >= threshold)
			tweak = new Vector2(
				-Mathf.Sign(GetComponent<Rigidbody2D>().velocity.x) * Random.Range(0f,0.2f), 
				-Mathf.Sign(GetComponent<Rigidbody2D>().velocity.y) * Random.Range(0f,0.2f));
		
		if(Mathf.Abs (GetComponent<Rigidbody2D>().velocity.y) < 6)
			tweak += new Vector2(
				0, 
				Mathf.Sign(GetComponent<Rigidbody2D>().velocity.y) * Random.Range(0f,0.2f));
				
		if(Mathf.Abs (GetComponent<Rigidbody2D>().velocity.x) < 1.5)
			tweak += new Vector2(
				Mathf.Sign(GetComponent<Rigidbody2D>().velocity.x) * Random.Range(0f,0.2f),
				0);
				
		GetComponent<Rigidbody2D>().velocity += tweak;
				
		if(!primed)
			GetComponent<AudioSource>().Play ();
	}
}
