using UnityEngine;
using System.Collections;

public class duvar : MonoBehaviour {


	public arabasahnesises arabasahnesi;


	void OnCollisionEnter2D(Collision2D col){
		if (col.gameObject.tag == "araba") 
		{
 
			arabasahnesi.bariyersescal ();
			 

		}
	}

 
	 

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
