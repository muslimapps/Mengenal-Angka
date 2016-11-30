using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class JawabanTebakBayangan : MonoBehaviour {

	public ScoreManager scoreManager;
	public SoalTebakBayangan soalTebakBayangan;
	public AudioClip[] suaraBenarClip;
	public AudioClip[] suaraSalahClip;
	int scoreValue = 10;
//	public Text jawaban1;
//	public Text jawaban2;
//	public Text jawaban3;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void BtnClickJawaban1() {
		if (soalTebakBayangan.jawabanRandom == 1) {
			if (soalTebakBayangan.GetComponent<AudioSource> ().isPlaying) {
				return;
			}
			if (scoreManager.suaraBenar.isPlaying) {
				return;
			}
			ScoreManager.scoreBenar += scoreValue;
			int nomerSuaraBenar = Random.Range (0, 2);
			scoreManager.suaraBenar.clip = suaraBenarClip[nomerSuaraBenar] ;
			scoreManager.suaraBenar.Play ();
			soalTebakBayangan.acakSoal = true;

		} else {
			if (soalTebakBayangan.GetComponent<AudioSource> ().isPlaying) {
				return;
			}
			if (scoreManager.suaraSalah.isPlaying) {
				return;
			}
			ScoreManager.scoreSalah += scoreValue;
			int nomerSuaraSalah = Random.Range (0, 2);
			scoreManager.suaraSalah.clip = suaraSalahClip[nomerSuaraSalah];
			scoreManager.suaraSalah.Play ();
			soalTebakBayangan.acakSoal = true;
		}
	}

	public void BtnClickJawaban2() {
		if (soalTebakBayangan.jawabanRandom == 2) {
			if (soalTebakBayangan.GetComponent<AudioSource> ().isPlaying) {
				return;
			}
			if (scoreManager.suaraBenar.isPlaying) {
				return;
			}
			ScoreManager.scoreBenar += scoreValue;
			int nomerSuaraBenar = Random.Range (0, 2);
			scoreManager.suaraBenar.clip = suaraBenarClip[nomerSuaraBenar] ;
			scoreManager.suaraBenar.Play ();
			soalTebakBayangan.acakSoal = true;

		} else {
			if (soalTebakBayangan.GetComponent<AudioSource> ().isPlaying) {
				return;
			}
			if (scoreManager.suaraSalah.isPlaying) {
				return;
			}
			ScoreManager.scoreSalah += scoreValue;
			int nomerSuaraSalah = Random.Range (0, 2);
			scoreManager.suaraSalah.clip = suaraSalahClip[nomerSuaraSalah];
			scoreManager.suaraSalah.Play ();
			soalTebakBayangan.acakSoal = true;
		}
	}

	public void BtnClickJawaban3() {
		if (soalTebakBayangan.jawabanRandom == 3) {
			if (soalTebakBayangan.GetComponent<AudioSource> ().isPlaying) {
				return;
			}
			if (scoreManager.suaraBenar.isPlaying) {
				return;
			}
			ScoreManager.scoreBenar += scoreValue;
			int nomerSuaraBenar = Random.Range (0, 2);
			scoreManager.suaraBenar.clip = suaraBenarClip[nomerSuaraBenar] ;
			scoreManager.suaraBenar.Play ();
			soalTebakBayangan.acakSoal = true;

		} else {
			if (soalTebakBayangan.GetComponent<AudioSource> ().isPlaying) {
				return;
			}
			if (scoreManager.suaraSalah.isPlaying) {
				return;
			}
			ScoreManager.scoreSalah += scoreValue;
			int nomerSuaraSalah = Random.Range (0, 2);
			scoreManager.suaraSalah.clip = suaraSalahClip[nomerSuaraSalah];
			scoreManager.suaraSalah.Play ();
			soalTebakBayangan.acakSoal = true;
		}
	}
}
