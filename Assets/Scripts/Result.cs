using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Result : MonoBehaviour {

	public Text benar;
	public Text salah;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		benar.text = "Benar : " + ScoreManager.scoreBenar;
		salah.text = "Salah : " + ScoreManager.scoreSalah;
	}

	public void resetBtnBayangan() {
		ScoreManager.scoreBenar = 0;
		ScoreManager.scoreSalah = 0;
//		SoalTebakBayangan soalTebakBayangan = new SoalTebakBayanga
//		soalTebakBayangan.jumlahSoal = 0;
	}
}
