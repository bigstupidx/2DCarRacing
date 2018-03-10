using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class ses : MonoBehaviour {

	public Slider MusicSoundSlider;
	public Slider buttonsoundslider;
	 
	public AudioSource ThemeMusic;
	public AudioSource buttonmusic;
 
	void Start () {

		InvokeRepeating ("MyUpdate", 0,1f);

		MusicSoundSlider.value = PlayerPrefs.GetFloat ("MusicSound");
		buttonsoundslider.value = PlayerPrefs.GetFloat ("SoundFX");

	}

	void MyUpdate () {

		PlayerPrefs.SetFloat ("MusicSound", MusicSoundSlider.value);
		PlayerPrefs.SetFloat ("SoundFX", buttonsoundslider.value);
		PlayerPrefs.Save ();

		ThemeMusic.volume = PlayerPrefs.GetFloat ("MusicSound");
		buttonmusic.volume = PlayerPrefs.GetFloat ("SoundFX");


	}
}
