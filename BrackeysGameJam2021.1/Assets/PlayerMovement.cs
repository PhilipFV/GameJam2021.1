using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	public float walkSpeed;

	public bool invertHorizontalInput; // bool that controlls if the lef and right inputs are inverted
	private float horizontalMultiplier;
	//public bool invertVerticalInput; // probably don't need this


	private Rigidbody2D rb;

	void Start()
	{
		rb = gameObject.GetComponent<Rigidbody2D>();
	}

	void Update()
	{
		if (invertHorizontalInput) horizontalMultiplier = -1;
		else horizontalMultiplier = 1;
	}

	void FixedUpdate()
	{
		float horizontalInput = Input.GetAxis("Horizontal") * horizontalMultiplier;

		rb.velocity = new Vector2(horizontalInput * walkSpeed, rb.velocity.y);
	}
}
