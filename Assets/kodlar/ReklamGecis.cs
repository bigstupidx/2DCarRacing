using UnityEngine;
using UnityEngine;
using System.Collections;
using GoogleMobileAds.Api;

public class ReklamGecis : MonoBehaviour
{
	
	private InterstitialAd reklamObjesi;

	public void reklamal()
	{
		 
			if( reklamObjesi != null )
				reklamObjesi.Destroy();

		reklamObjesi = new InterstitialAd( "ca-app-pub-1167986022782357/2098479428" );
			AdRequest reklamiAl = new AdRequest.Builder().Build();
			reklamObjesi.LoadAd( reklamiAl );
		 
		}

	public void cekgoster()
	{
		StartCoroutine (ReklamiGoster());
	}
 

	IEnumerator ReklamiGoster()
	{
		Debug.Log ("reklamlarr.r.");
		while( !reklamObjesi.IsLoaded() )
			yield return null;

		reklamObjesi.Show();
	}
}