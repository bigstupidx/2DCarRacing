
using UnityEngine;
using System.Collections;
 
public class arabaolus : MonoBehaviour { 

public bool acik;
public GameObject pausepanel1;
 
public GameObject[] cars;
public int carNo;
public float maxPos = 2.2f;
public float delayTimer = 1.0f;
public float timer;
 
 
 

	 

	void Start () {

		timer = delayTimer;
		 



	
	}

	public void anamenubutton()
	{
		Application.LoadLevel (0);
	}
	public void pausepanetekraroyna()
	{
		Application.LoadLevel("arabasahne01");
	}

	public void pausepanel()
	{

	 
		acik=!acik;
		if (acik) 
		{ 
			Time.timeScale = 0;
			pausepanel1.SetActive (true);

		}
		else
		{
			Time.timeScale=1;
			pausepanel1.SetActive(false);
			 
			
		}
		
	}





	void Update ()
	{
		
			

		
	


	}




}
