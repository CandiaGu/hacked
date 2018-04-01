using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SphereScript : MonoBehaviour {
	private Rigidbody rb;
	private int count;
	public Text countText;
	public float speed;
	void Start()
	{
		rb = GetComponent<Rigidbody> ();
		count = 0;
		countText.text = "Count" + count.ToString ();
	}
	void FixedUpdate()
	{
		float moveH = Input.GetAxis ("Horizontal");
		float moveV = Input.GetAxis ("Vertical");
		Vector3 movement = new Vector3 (moveH, 0.0f, moveV);
		rb.AddForce (speed*movement);
	}

	void OnTriggerEnter(Collider other) 
	{
		if (other.gameObject.CompareTag ("Pick Up"))
		{
			count += 1;
			other.gameObject.SetActive (false);		
			countText.text = "Count" + count.ToString ();
		}
	}
}
