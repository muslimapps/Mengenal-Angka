using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SoalTebakAngka : MonoBehaviour {

	public AngkaManager angkaManager;
	public ScoreManager scoreManager;
	public AudioClip[] suaraSoal;
	public Text rendererJawaban1;
	public Text rendererJawaban2;
	public Text rendererJawaban3;
	public int jumlahSoal;
	public int jawabanRandom = -1;
	public bool soalAcak;

	public GameObject dis;
	public GameObject ena;
	// Use this for initialization
	void Start () {
		jumlahSoal = 0;
		soalAcak = true;
	}
	
	// Update is called once per frame
	void Update () {
		if (jumlahSoal > 10) {
			jumlahSoal = 0;
		}

		if (scoreManager.suaraBenar.isPlaying || scoreManager.suaraSalah.isPlaying) {
			return;
		}

		if (ScoreManager.scoreBenar + ScoreManager.scoreSalah == 10) {
			ena.SetActive (true);
			dis.SetActive (false);
			return;
		}
		if (soalAcak && jumlahSoal < 10) {
			jumlahSoal += 1;

			int soalRandom = Random.Range (0, 9);

			jawabanRandom = Random.Range (1, 4);

			int jawaban1 = soalRandom;
			int jawaban2 = soalRandom;
			int jawaban3 = soalRandom;

			if (jawabanRandom == 1) {
				while (jawaban2 == soalRandom) {
					jawaban2 = Random.Range (0, 9);
				}
				while (jawaban3 == soalRandom || jawaban3 == jawaban2) {
					jawaban3 = Random.Range (0, 9);
				}
			} else if (jawabanRandom == 2) {
				while (jawaban1 == soalRandom) {
					jawaban1 = Random.Range (0, 9);
				}
				while (jawaban3 == soalRandom || jawaban3 == jawaban1) {
					jawaban3 = Random.Range (0, 9);
				}
			} else if (jawabanRandom == 3) {
				while (jawaban2 == soalRandom) {
					jawaban2 = Random.Range (0, 9);
				}
				while (jawaban1 == soalRandom || jawaban1 == jawaban2) {
					jawaban1 = Random.Range (0, 9);
				}
			}

			GetComponent<AudioSource> ().clip = suaraSoal [soalRandom];

			rendererJawaban1.text = angkaManager.daftarAngka [jawaban1].angkaNum;
			rendererJawaban2.text = angkaManager.daftarAngka [jawaban2].angkaNum;
			rendererJawaban3.text = angkaManager.daftarAngka [jawaban3].angkaNum;

			if (GetComponent<AudioSource> ().clip != null) {
				GetComponent<AudioSource> ().Play ();
			}
		}
		soalAcak = false;
	}

	public void resetBtn() {
		soalAcak = true;
		jumlahSoal = 0;
		ScoreManager.scoreBenar = 0;
		ScoreManager.scoreSalah = 0;

	}
}
