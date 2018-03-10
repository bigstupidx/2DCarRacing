using UnityEngine;
using UnityEngine;
using GoogleMobileAds.Api;

public class Reklam : MonoBehaviour
{
	 
	public BannerView reklamObjesi;

	void Start()
	{
		 

		reklamObjesi = new BannerView(
			"ca-app-pub-1167986022782357/5309297823", AdSize.SmartBanner, AdPosition.Bottom );
		AdRequest reklamiAl = new AdRequest.Builder().Build();
		reklamObjesi.LoadAd( reklamiAl );
	}

	 
}



