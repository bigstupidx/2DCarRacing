using UnityEngine;
using System.Collections;

public class arabasahnesises : MonoBehaviour {
	public AudioSource source;
	public AudioClip  kazayapmasesi;
	public AudioClip gameoversesi;
	public AudioClip coinsesi;
	public AudioClip buttonses;
	public AudioClip yagses;
	public AudioClip bariyerses;
	public AudioClip kursunses;
	// Use this for initialization
	void Start () {
		source = GetComponent<AudioSource> ();
	}
	public void sescal(){

		source.PlayOneShot (buttonses, 0.7f);
		 

	}


	public void bariyersescal(){


		 
		source.PlayOneShot (bariyerses, 0.7f);


	}

	 

	public void yagsescal()
	{
		source.PlayOneShot (yagses, 0.7f);
	}
	public void kursunsescal()
	{
		source.PlayOneShot (kursunses, 0.7f);
	}

	public void gameoversesical(){

		source.PlayOneShot (gameoversesi, 0.7f);


	}
	public void coinsesical(){

		source.PlayOneShot (coinsesi, 0.7f);


	}
	public void kazayapmassiscal(){

		source.PlayOneShot (kazayapmasesi, 0.7f);


	}
}
