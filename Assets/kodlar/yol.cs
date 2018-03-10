using UnityEngine;
using System.Collections;

public class yol : MonoBehaviour {
	public float speed;
	Vector2 offset;
	public carController carsc;
	 

	void Start () {
	

	
	}
	
 
	void Update () {

		if (carsc.hizyukseltmeyegeldimi == false && carsc.ambulansacarptimi == false && carsc.polisecarptimi == false) {
			offset = new Vector2 (0,Time.time*speed);
			GetComponent<Renderer> ().material.mainTextureOffset = offset;
		}



		if (carsc.ambulansacarptimi == true)
		{
			 
			offset = new Vector2 (0,(float)Time.time*speed*1.5f);
			GetComponent<Renderer> ().material.mainTextureOffset = offset;
		


		}

		if (carsc.polisecarptimi == true)
		{
			 
			offset = new Vector2 (0,(float)Time.time*speed*1.5f);
			GetComponent<Renderer> ().material.mainTextureOffset = offset;



		}

		if (carsc.hizyukseltmeyegeldimi == true)
		{

			 
			offset = new Vector2 (0,(float)Time.time*speed*0.5f);
			GetComponent<Renderer> ().material.mainTextureOffset = offset;



		}



	
	}
}
