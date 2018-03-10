
using UnityEngine;
using System.Collections;

public class spwn : MonoBehaviour { 
	 
	public GameObject[] cars;
	public int hangiaraba;

	public float timer;
	public int seviyelal;

	public carController carcs;
	public int tekrarla = 0;
	
	
	void Start () {
		 
		seviyelal = PlayerPrefs.GetInt ("seviye");
	
		
	}
	
	
	 
	
	
	
	
	
	void Update ()
	{
		

		if (seviyelal == 1) {
			if (carcs.hizartirilsinmi == true) {
				 
				float delaytimer = 2.2f;
				timer -= Time.deltaTime;
				if (timer <= 0) {
					hangiaraba = Random.Range (0, 13);
					 
					Vector3 carPos = new Vector3 (Random.Range (-1.85f, 1.85f), transform.position.y, transform.position.z);

					Instantiate (cars [hangiaraba], carPos, transform.rotation);
					timer = delaytimer;
				} 
			} else {
				float delaytimer = 1.8f;
				timer -= Time.deltaTime;
				if (timer <= 0) {
					hangiaraba = Random.Range (0, 13);
				 
					Vector3 carPos = new Vector3 (Random.Range (-1.85f, 1.85f), transform.position.y, transform.position.z);

					Instantiate (cars [hangiaraba], carPos, transform.rotation);
					timer = delaytimer;

				}
			}
		}
		 
		 


		if (seviyelal == 2) 
		
		{
			if (carcs.hizartirilsinmi == true) {
				float delaytimer = 1.8f;
					 

					timer -= Time.deltaTime;
					if (timer <= 0) {
						hangiaraba = Random.Range (0, 13);
					 
					Vector3 carPos = new Vector3 (Random.Range (-1.85f, 1.85f), transform.position.y, transform.position.z);

						Instantiate (cars [hangiaraba], carPos, transform.rotation);
						timer = delaytimer;

					}
			} else {
				float delaytimer = 1.3f;

				timer -= Time.deltaTime;
				if (timer <= 0) {
					hangiaraba = Random.Range (0, 13);
				 
					Vector3 carPos = new Vector3 (Random.Range (-1.85f, 1.85f), transform.position.y, transform.position.z);

					Instantiate (cars [hangiaraba], carPos, transform.rotation);
					timer = delaytimer;

				}
			}

			 
			}


		if (seviyelal == 3)
		{
				if (carcs.hizartirilsinmi == true) {
					float delaytimer = 1.5f;
					 
					timer -= Time.deltaTime;
					if (timer <= 0) {
						hangiaraba = Random.Range (0, 13);
						 
					Vector3 carPos = new Vector3 (Random.Range (-1.85f, 1.85f), transform.position.y, transform.position.z);

						Instantiate (cars [hangiaraba], carPos, transform.rotation);
						timer = delaytimer;






					}
				} else {
					float delaytimer = 0.9f;
					timer -= Time.deltaTime;
					if (timer <= 0) {
						hangiaraba = Random.Range (0, 13);
					 
					Vector3 carPos = new Vector3 (Random.Range (-1.85f, 1.85f), transform.position.y, transform.position.z);

						Instantiate (cars [hangiaraba], carPos, transform.rotation);
						timer = delaytimer;

		 
		 



					}
				}
		 

		
		
		
		
	}
	
	
	
	
}
}
 