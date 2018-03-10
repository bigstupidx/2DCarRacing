using UnityEngine;
using System.Collections;

public class arabalarısil : MonoBehaviour {
 

	 void Start()
	{
		 
	}
 
	void OnCollisionEnter2D(Collision2D col){
		if (col.gameObject.tag == "ambulans") {
		 
			Destroy(col.gameObject);	

	}
		if (col.gameObject.tag == "polis") {

			Destroy(col.gameObject);	

		}
		if (col.gameObject.tag == "hızyukselt") {

			Destroy(col.gameObject);	

		}
		if (col.gameObject.tag == "enemycar") {

			Destroy(col.gameObject);	

		}

		if (col.gameObject.tag == "zamanarttir") {

			 
			Destroy (col.gameObject);	




		}
		if (col.gameObject.tag == "wifi") {


			Destroy (col.gameObject);	




		}
		if (col.gameObject.tag == "yag") {


			Destroy (col.gameObject);	




		}
}
 
}
