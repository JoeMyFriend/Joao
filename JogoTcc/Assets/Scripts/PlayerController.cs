using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {


	public Animator anime;
	public Rigidbody2D 	playerRigidBody;
	public int forceJump;
	public int speed;
	public int maxSpeed;

	public bool jump;
	public bool run;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetButtonDown ("Jump")) {
			playerRigidBody.AddForce (new Vector2 (0, forceJump));
			jump = true;

		}
		if(Input.GetAxisRaw("Horizontal") > 0){
			playerRigidBody.AddForce (new Vector2((speed) * Time.deltaTime, 0));
			run = true;
			playerRigidBody.transform.eulerAngles = new Vector2 (0, 0);
		}

		if(Input.GetAxisRaw("Horizontal") < 0){
			playerRigidBody.AddForce (new Vector2((speed) * Time.deltaTime * -1, 0));
			run= true;
			playerRigidBody.transform.eulerAngles = new Vector2 (0, 180);
		}

		if(Input.GetButtonUp("Horizontal")){
			run = false;
		}

		anime.SetBool ("run", run);

	}
}