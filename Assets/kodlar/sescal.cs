using UnityEngine;
using System.Collections;

public class sescal : MonoBehaviour {
	public AudioSource source;
	public float zamandursunmu = 2.5f;
	public bool bastimi = false; 
	 

	// Use this for initialization
	void Start () {
		source = GetComponent<AudioSource> ();


	}
	
	// Update is called once per frame
	void Update () {
		
		if (bastimi == true) {
			zamandursunmu -= Time.deltaTime;
			if ((int)zamandursunmu == 0) {
				Application.LoadLevel ("arabasahne01");
			
			 
				source.Stop ();

			}
		}

	
	}
	public void kontakpanel(){
		Time.timeScale = 1;
		source.Play();
		bastimi = true;

	}
}
