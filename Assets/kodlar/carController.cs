using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class carController : MonoBehaviour {

	public bool sagaHareket;
	
	public bool solaHareket;
	
	public int hiz;
	public bool acikmi;
	public GameObject pausepanel;
	public int can;
	public Text canyaz;
	public float zaman;
	public Text zamanyaz;
	public float carSpeed;
	public float maxPos = 2.2f;
	 
	public AudioClip arabasesi;
	public AudioSource sourcem;
	public GameObject gameoverpanel;
	Vector3 position;
	 
	public arabasahnesises arababuttonses;



	public float ambulanszaman = 1.0f;
	public float poliszaman = 1.0f;
	public float hizyukseltzaman = 1.0f;
	public bool ambulansacarptimi;
	public bool polisecarptimi;
	public bool hizyukseltmeyegeldimi;

	public ReklamGecis reklamcs; 



	public int skor;
	public int yuksekskor;
	public Text yuksekkortext;

	public bool zamanartsinmi;
	public int zamancarp = 4;
	public bool hizartirilsinmi;
	public bool yagadegdi;
	public bool solacarptimi;
	public bool sagacarptimi;
	public GameObject arabatransform;
	public GameObject bulletPrefab;
	public Transform bulletSpawn;

	public Button firebutton;

	 

	void Awake(){

		firebutton.gameObject.SetActive (true);
	 
		sourcem = GetComponent<AudioSource> ();
	}
	
	void Start () {
		sourcem.Play ();
		reklamcs.reklamal ();
	
		position = transform.position;
		can = 3;

	}

	

	void Update () {


		if (solacarptimi == true)
		{

			transform.Translate(0, 0, 0);
			solacarptimi = false;
		}
		if(sagacarptimi == true)
		{
			transform.Translate((3*-hiz) * Time.deltaTime, 0, 0);
			sagacarptimi 	= false;
			
		}



		if (yagadegdi == true)
		{
			
		}
		else
		{

			if(sagaHareket)
			{
				transform.Translate(hiz * Time.deltaTime, 0, 0);

			}

			if (solaHareket)
			{
				transform.Translate(-hiz * Time.deltaTime, 0, 0);
			}
			if (zamanartsinmi == true)
			{
				zaman = zaman + Time.deltaTime *zamancarp;
			}
			else
			{
				zaman = zaman + Time.deltaTime;
			}
		}







	 	
	
	position.x = Mathf.Clamp (position.x, -2.2f, 2.2f);
		zamanyaz.text = "TIME : " + (int) zaman;
	canyaz.text = "HEALTH : " + can;
	 
	


	}
	 

	public void Sol(int button)
	{
		if(button==0)
		{
			solaHareket = false;
		}
		if(button==1)
		{
			solaHareket = true;
		}
	}
	public void Sag(int button)
	{
		if (button == 0)
		{
			sagaHareket = false;
		}
		if (button == 1)
		{
			sagaHareket = true;
		}
	}

	public void anamenubutton()
	{
		arababuttonses.sescal ();
		sourcem.Stop ();
		Time.timeScale = 1;
		gameoverpanel.SetActive (false);
		Application.LoadLevel (0);

	}
 

	void OnCollisionEnter2D(Collision2D collider)
	{
		
		if (collider.gameObject.tag == "enemycar") {
			zamanartsinmi = false;
			hizartirilsinmi = false;
			Destroy (collider.gameObject);
			arababuttonses.kazayapmassiscal ();
	
			can--;

			if (can == 0) {
				arababuttonses.gameoversesical ();
			 
				skor = (int)zaman;
				reklamcs.cekgoster ();
				 
		
				if (skor > PlayerPrefs.GetInt("yuksekskor")) {
					PlayerPrefs.SetInt ("yuksekskor" , skor);
					yuksekkortext.text = "High Score : " + PlayerPrefs.GetInt ("yuksekskor");
				}
				else
				{
					yuksekkortext.text = "Score : " + skor;
				}


				firebutton.gameObject.SetActive (false);
			 	Time.timeScale = 0;
				gameoverpanel.SetActive (true);
		
				Destroy (gameObject);
 
			}
		}


		 

 
		if (collider.gameObject.tag == "zamanarttir") {
			arababuttonses.coinsesical ();
			zamanartsinmi = true;
			hizartirilsinmi = false;
		 
			Destroy (collider.gameObject);	




		}
		if (collider.gameObject.tag == "wifi") {
			reklamcs.cekgoster ();
		 
			Destroy (collider.gameObject);	
			skor = (int)zaman;
			reklamcs.cekgoster ();

		
			if (skor > PlayerPrefs.GetInt("yuksekskor")) {
				PlayerPrefs.SetInt ("yuksekskor" , skor);
				yuksekkortext.text = "High Score : " + PlayerPrefs.GetInt ("yuksekskor");
			}
			else
			{
				yuksekkortext.text = "Score : " + skor;
			}

			firebutton.gameObject.SetActive (false);

			Time.timeScale = 0;
			gameoverpanel.SetActive (true);
		
			Destroy (gameObject);




		}


	 

		if (collider.gameObject.tag == "hızyukselt") {
			arababuttonses.coinsesical ();
			zamanartsinmi = false;
			hizartirilsinmi = true;
			Destroy (collider.gameObject);	

		}
		if (collider.gameObject.tag == "sol") {
			
			solacarptimi = true;


		}
		if (collider.gameObject.tag == "sag") {

			sagacarptimi = true;


		}
		if (collider.gameObject.tag == "yag") {
			arababuttonses.yagsescal ();
			 
			yagadegdi = true;

			StartCoroutine (yanver());
			 
	
			Destroy (collider.gameObject);	


		}

	}
	public IEnumerator yanver()
	{
		
		arabatransform.transform.eulerAngles = new Vector3 (0,0,10);
		yield return new WaitForSeconds (0.3f);
	
		arabatransform.transform.eulerAngles = new Vector3 (0,0,20);
		yield return new WaitForSeconds (0.3f);
		arabatransform.transform.eulerAngles = new Vector3 (0,0,30);
		yield return new WaitForSeconds (0.6f);
		arabatransform.transform.eulerAngles = new Vector3 (0,0,0);
		yagadegdi = false;
	 



	}



	 



	public void ateset()
	{
		arababuttonses.kursunsescal ();
		Fire();
	}

		  


			 
				
		 


		public void Fire()
		{
		 

			var bullet = (GameObject)Instantiate(
				bulletPrefab,
				bulletSpawn.position,
				bulletSpawn.rotation);
	
		bullet.GetComponent<Rigidbody2D>().velocity = bullet.transform.up * 6;
	
			
			Destroy(bullet, 2.0f); 
		 
		}

	public void yoket()
	{

	}

		 
	 



















	public void pausepaneldevamet()
	{
		firebutton.gameObject.SetActive (true);
		arababuttonses.sescal ();
		Time.timeScale = 1;	
		sourcem.Play ();
		pausepanel.gameObject.SetActive (false);

	}


	public void again()

	{
		firebutton.gameObject.SetActive (false);
		arababuttonses.sescal ();

		 
			sourcem.Stop ();
			pausepanel.SetActive(true);
			Time.timeScale=0;
		 
	}

	public void pauseagain()
	{
		arababuttonses.sescal ();
		sourcem.Stop ();
		Time.timeScale=1;
		Application.LoadLevel(Application.loadedLevel);
	}
	 
 


}
