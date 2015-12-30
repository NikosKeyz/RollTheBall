using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerController : MonoBehaviour {

	private static int NUMBER_OF_CUBES = 19;

	public float speed;
	public Text CountText;
	private Rigidbody rigidBody;
	private int count;

	void Start() 
	{
		count = 0;
		SetCountText ();
		rigidBody = GetComponent<Rigidbody> ();
	}

	void FixedUpdate() 
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		rigidBody.AddForce (movement * speed);
	}

	void OnTriggerEnter(Collider other) 
	{
		if (other.gameObject.CompareTag ("PickUp"))
		{
			other.gameObject.SetActive (false);
			count++;
			SetCountText ();
		}
	}

	void SetCountText() 
	{
		if ( count == NUMBER_OF_CUBES )
			CountText.text = "You WON !!!";
		else
			CountText.text = "Cubes: " + count.ToString ();
	}
}