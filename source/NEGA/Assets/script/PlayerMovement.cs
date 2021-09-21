using System.Collections;
using System.Collections.Generic;
using System.Security.Policy;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

	public float sideForce = 8f;
	public float updirection = 5f;
	public float forwardForce = 8f;

	public Rigidbody playerBody;

	private bool canMove = true;
    private CharacterController controller;
    private Vector3 direction;
	private float gravity = -20f;

    // Use this for initialization
    void Start()
	{
		playerBody = GetComponent<Rigidbody>();
		controller = GetComponent<CharacterController>();
	}

	// Update is called once per frame
	void Update()
	{
		if (canMove)
		{
			makeMovement();
		}
	}

	// this is for movement;
	private void makeMovement()
    {
		direction.z = forwardForce;
		direction.x = Input.GetAxis("Horizontal") * sideForce;
		direction.y += gravity * Time.deltaTime;

		if (Input.GetButtonDown("Jump") && controller.isGrounded)
		{
			direction.y = updirection;
		}

		controller.Move(direction * Time.deltaTime);
		if (transform.position.x > 10.2 || transform.position.x < -10.2)
		{
			enabled = false;
			canMove = false;

			//playerBody.constraints = RigidbodyConstraints.None;
			//Debug.Log("hi babe");
		}
	}

}
