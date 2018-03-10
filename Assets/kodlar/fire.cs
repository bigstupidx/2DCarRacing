using UnityEngine;
using System.Collections;

public class fire : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D(Collision2D collider)
	{

		if (collider.gameObject.tag == "enemycar") {
 
			Destroy (collider.gameObject);

		}
		if (collider.gameObject.tag == "wifi")
		{
			Destroy (collider.gameObject);
		}
		if (collider.gameObject.tag == "yag")
		{
			Destroy (collider.gameObject);

		}
		if (collider.gameObject.tag == "zamanarttir")
		{
			Destroy (collider.gameObject);
		}
		if (collider.gameObject.tag == "hızyukselt") 
		{
			Destroy (collider.gameObject);
		}
	}
}
