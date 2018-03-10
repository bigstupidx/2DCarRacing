using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class againgameover : MonoBehaviour {
	public GameObject gameoverpanel;
	public arabasahnesises arabasahnesises;
	 
	public void gameoveragain()
	{
		arabasahnesises.sescal ();
		gameoverpanel.SetActive(false);
		Time.timeScale=1;
		Application.LoadLevel(1);

	}

	 
}
