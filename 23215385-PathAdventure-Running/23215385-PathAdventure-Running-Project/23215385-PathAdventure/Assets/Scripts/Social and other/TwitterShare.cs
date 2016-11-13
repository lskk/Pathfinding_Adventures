using UnityEngine;
using System.Collections;

public class TwitterShare : MonoBehaviour {
	
	private const string TWITTER_ADDRESS = "http://twitter.com/auliamuslim";
	private const string TWEET_LANGUAGE = "en";

	public string text;

	public void ShareToTwitter ()
	{
		Application.OpenURL(TWITTER_ADDRESS + "?text=" + WWW.EscapeURL(text + PlayerPrefs.GetFloat("CurrentScore").ToString("F2") + "m") + "&lang=" + WWW.EscapeURL(TWEET_LANGUAGE));
	}
}
