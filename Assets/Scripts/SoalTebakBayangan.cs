using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SoalTebakBayangan : MonoBehaviour {

	public AngkaManager angkaManager;
	public bool acakSoal;
	public AudioSource suaraSource;
	public AudioClip suaraAwal;
	public Text rendererSoal;
	public Text rendererJawaban1;
	public Text rendererJawaban2;
	public Text rendererJawaban3;
	public int jawabanRandom = -1;
	public int jumlahSoal;
	public ScoreManager scoreManager;

	public GameObject permainanDis;
	public GameObject resultEna;
	// Use this for initialization
	void Start () {
		jumlahSoal = 0;
		acakSoal = true;

	}
	
	// Update is called once per frame
	void Update () {
		if (jumlahSoal >= 10) {
			jumlahSoal = 0;
		}
		if (acakSoal && jumlahSoal < 10) {

			if (scoreManager.suaraBenar.isPlaying || scoreManager.suaraSalah.isPlaying) {
				return;
			}

			if (ScoreManager.scoreBenar + ScoreManager.scoreSalah >= 100) {
				resultEna.SetActive (true);
				permainanDis.SetActive (false);
				return;
			}

			jumlahSoal += 1;

			int soalRandom = Random.Range(0,9);

			jawabanRandom = Random.Range(1,4);

			int jawaban1 = soalRandom;
			int jawaban2 = soalRandom;
			int jawaban3 = soalRandom;

			if (jawabanRandom == 1) {
				while (jawaban2 == soalRandom) {
					jawaban2 = Random.Range(0,9);
				}
				while (jawaban3 == soalRandom || jawaban3 == jawaban2) {
					jawaban3 = Random.Range(0,9);
				}
			} else if (jawabanRandom == 2) {
				while (jawaban1 == soalRandom) {
					jawaban1 = Random.Range(0,9);
				}
				while (jawaban3 == soalRandom || jawaban3 == jawaban1) {
					jawaban3 = Random.Range(0,9);
				}
			} else if (jawabanRandom == 3) {
				while (jawaban2 == soalRandom) {
					jawaban2 = Random.Range(0,9);
				}
				while (jawaban1 == soalRandom || jawaban1 == jawaban2) {
					jawaban1 = Random.Range(0,9);
				}
			}
			rendererSoal.text = angkaManager.daftarAngka [soalRandom].angkaNum;

			rendererJawaban1.text = angkaManager.daftarAngka [jawaban1].angkaNum;
			rendererJawaban2.text = angkaManager.daftarAngka [jawaban2].angkaNum;
			rendererJawaban3.text = angkaManager.daftarAngka [jawaban3].angkaNum;

			suaraSource.clip = suaraAwal;
			suaraSource.Play ();
		}
		acakSoal = false;
	}

	public void resetBtn() {
		acakSoal = true;
		jumlahSoal = 0;
		ScoreManager.scoreBenar = 0;
		ScoreManager.scoreSalah = 0;

	}
}
