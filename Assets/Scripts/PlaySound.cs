using UnityEngine;
using System.Collections;

public class PlaySound : MonoBehaviour {

	public SoalTebakAngka soalTebakAngka;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void play() {
		if (GetComponent<AudioSource>().isPlaying) {
			return;
		}
		GetComponent<AudioSource> ().Play ();
	}

	public void repeatSound() {
		soalTebakAngka.GetComponent<AudioSource> ().Play ();
	}
}
