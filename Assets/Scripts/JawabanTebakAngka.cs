using UnityEngine;
using System.Collections;

public class JawabanTebakAngka : MonoBehaviour {

	public ScoreManager scoreManager;
	public SoalTebakAngka soalTebakAngka;
	public AudioClip[] suaraJawabanBenar;
	public AudioClip[] suaraJawabanSalah;
	public int scoreValue = 1;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void btnJawaban1() {
		if (soalTebakAngka.jawabanRandom == 1) {
			if (soalTebakAngka.GetComponent<AudioSource> ().isPlaying) {
				return;
			}
			if (scoreManager.suaraBenar.isPlaying) {
				return;
			}
			int nmrSuaraBenar = Random.Range (0, 2);
			scoreManager.suaraBenar.clip = suaraJawabanBenar [nmrSuaraBenar];
			scoreManager.suaraBenar.Play ();
			ScoreManager.scoreBenar += scoreValue;
			soalTebakAngka.soalAcak = true;
		} else {
			if (soalTebakAngka.GetComponent<AudioSource> ().isPlaying) {
				return;
			}
			if (scoreManager.suaraSalah.isPlaying) {
				return;
			}
			int nmrSuaraSalah = Random.Range (0, 2);
			scoreManager.suaraSalah.clip = suaraJawabanSalah [nmrSuaraSalah];
			scoreManager.suaraSalah.Play ();
			ScoreManager.scoreSalah += scoreValue;
			soalTebakAngka.soalAcak = true;
		}
	}

	public void btnJawaban2() {
		if (soalTebakAngka.jawabanRandom == 2) {
			if (soalTebakAngka.GetComponent<AudioSource> ().isPlaying) {
				return;
			}
			if (scoreManager.suaraBenar.isPlaying) {
				return;
			}

			int nmrSuaraBenar = Random.Range (0, 2);
			scoreManager.suaraBenar.clip = suaraJawabanBenar [nmrSuaraBenar];
			scoreManager.suaraBenar.Play ();
			ScoreManager.scoreBenar += scoreValue;
			soalTebakAngka.soalAcak = true;
		} else {
			if (soalTebakAngka.GetComponent<AudioSource> ().isPlaying) {
				return;
			}
			if (scoreManager.suaraSalah.isPlaying) {
				return;
			}
			int nmrSuaraSalah = Random.Range (0, 2);
			scoreManager.suaraSalah.clip = suaraJawabanSalah [nmrSuaraSalah];
			scoreManager.suaraSalah.Play ();
			ScoreManager.scoreSalah += scoreValue;
			soalTebakAngka.soalAcak = true;
		}
	}

	public void btnJawaban3() {
		if (soalTebakAngka.jawabanRandom == 3) {
			if (soalTebakAngka.GetComponent<AudioSource> ().isPlaying) {
				return;
			}
			if (scoreManager.suaraBenar.isPlaying) {
				return;
			}
			int nmrSuaraBenar = Random.Range (0, 2);
			scoreManager.suaraBenar.clip = suaraJawabanBenar [nmrSuaraBenar];
			scoreManager.suaraBenar.Play ();
			ScoreManager.scoreBenar += scoreValue;
			soalTebakAngka.soalAcak = true;
		} else {
			if (soalTebakAngka.GetComponent<AudioSource> ().isPlaying) {
				return;
			}
			if (scoreManager.suaraSalah.isPlaying) {
				return;
			}
			int nmrSuaraSalah = Random.Range (0, 2);
			scoreManager.suaraSalah.clip = suaraJawabanSalah [nmrSuaraSalah];
			scoreManager.suaraSalah.Play ();
			ScoreManager.scoreSalah += scoreValue;
			soalTebakAngka.soalAcak = true;
		}
	}
}
