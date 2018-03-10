using UnityEngine;
using System.Collections;

public class giris : MonoBehaviour {
	public GameObject[] butonlar;
	public GameObject playbuton;
	public GameObject cikispanel; 
	public GameObject ayarpanel;

	public bool ayarpanelacik;
	public bool boolcikispanel;
	public GameObject kontakpanel;
	public Reklam reklamilkcs;

	public AudioSource source;




void Awake()
	{
		source.GetComponent<AudioSource> ();
		playbuton.SetActive(false);
	}
	public void butonlarkontrol(string butonlarım)
	{

		if(butonlarım == "easy")
		{
			source.Play ();
			PlayerPrefs.SetInt ("seviye" , 1 );
			playbuton.SetActive(true);
		}
		if(butonlarım == "medium")
		{
			source.Play ();
			PlayerPrefs.SetInt ("seviye" , 2 );
			playbuton.SetActive(true);
		}
		if(butonlarım == "hard")
		{
			source.Play ();
			PlayerPrefs.SetInt ("seviye" , 3 );
			playbuton.SetActive(true);
		}

		if(butonlarım == "play")
		{
			source.Play ();
			reklamilkcs.reklamObjesi.Hide ();
		
			kontakpanel.SetActive(true);
		}
		if(butonlarım == "again")
		{
			source.Play ();
			Application.LoadLevel ("arabasahne01");
		}
	 
		if(butonlarım == "cik")
		{
			source.Play ();
			 
			cikispanel.SetActive(true);
			 
			 
			}
		if(butonlarım == "quit")
		{
			source.Play ();
			Application.Quit();
		}

		if (butonlarım == "ayargeri") {
			source.Play ();
			ayarpanel.SetActive (false);
		}

		if(butonlarım == "noquit")
		{
			source.Play ();
			cikispanel.SetActive(false);
		}
		if(butonlarım == "option" )
		{
			
			 
		 
			 
				source.Play ();
			ayarpanel.SetActive(true);
			}
		  
	}


 

}
