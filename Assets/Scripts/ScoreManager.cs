using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreManager : MonoBehaviour {

	public static int scoreBenar;
	public static int scoreSalah;

	public AudioSource suaraBenar;
	public AudioSource suaraSalah;
	public Text counterBenar;
	public Text counterSalah;

	// Use this for initialization
	void Start () {
		scoreBenar = 0;
		scoreSalah = 0;
	}
	
	// Update is called once per frame
	void Update () {
		counterBenar.text = "" + scoreBenar;
		counterSalah.text = "" + scoreSalah;
	}
}
