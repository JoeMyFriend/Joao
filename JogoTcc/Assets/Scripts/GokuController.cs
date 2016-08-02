using UnityEngine;
using System.Collections;

public class GokuController : MonoBehaviour {

	public Animator anime;

	public Rigidbody2D rigidbody;

	public bool transform;

	//AUDIO

	public AudioSource som;
	public AudioClip Billl;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButtonDown("Fire1")){
			transform = true;
			Debug.Log ("CHEGOU NESSA PARTE");
			som.PlayOneShot (Billl);
		}
		if(Input.GetButtonUp("Fire1")){
			transform = false;
		}

		anime.SetBool ("transform", transform);
	}
}
