using UnityEngine;
using System.Collections;

//using ADBannerView = UnityEngine.iOS.ADBannerView;

public class iAd : MonoBehaviour {
	
	public bool showOnTop = true;
	public bool dontDestroy = false;
	
	#if UNITY_IPHONE
	private ADBannerView banner;
	// Use this for initialization

	void Start () 
	{
		if(dontDestroy)
		{
			GameObject.DontDestroyOnLoad(gameObject);
		}
		
		//banner = new ADBannerView(ADBannerView.Type.Banner,showOnTop? ADBannerView.Layout.Top : ADBannerView.Layout.Bottom);
		//ADBannerView.onBannerWasLoaded += onBannerLoaded;
	}
	
	// onBannerLoaded is declared here
	void onBannerLoaded () 
	{
		banner.visible = true;
	}
	#endif
}