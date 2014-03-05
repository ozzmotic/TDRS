using UnityEngine;
using System.Collections;

[RequireComponent (typeof (CharacterController))]
public class PlayerController : MonoBehaviour {

	//Handling
	public float rotationSpeed = 450f;
	public float speed = 10;
	public float gravity = 20.0f;

	//Components
	private CharacterController controller;

	//System
	private Vector3 moveDirection = Vector3.zero;

	void Start () {
		controller = GetComponent<CharacterController>();
	}
	
	void Update () {
		moveDirection = new Vector3(Input.GetAxisRaw("Horizontal"),0,Input.GetAxisRaw("Vertical"));
		var v3 = Input.mousePosition;
		v3.z = 25.0f;
		v3 = Camera.main.ScreenToWorldPoint(v3);

		Vector3 lookPos = new Vector3(v3.x,transform.position.y,v3.z);
		transform.LookAt(lookPos);

		moveDirection *= speed;

		moveDirection.y -= gravity * Time.deltaTime;

		controller.Move(moveDirection * Time.deltaTime);
	}
}
