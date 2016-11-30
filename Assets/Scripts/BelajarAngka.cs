using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BelajarAngka : MonoBehaviour {

	public AngkaManager angkaManager;
	public int position;
	public AudioSource soundAngkaNum;
	public AudioSource soundAngkaIndo;
	public AudioSource soundAngkaEng;
	public Text angkaNum;
	public Text angkaIndo;
	public Text angkaEng;
	// public Image gambar;
	
	// Use this for initialization
	void Start () {
		position = 0;
		angkaNum.text = angkaManager.daftarAngka[position].angkaNum;
		angkaIndo.text = angkaManager.daftarAngka[position].angkaIndo;
		angkaEng.text = angkaManager.daftarAngka[position].angkaEng;
		soundAngkaIndo.clip = angkaManager.daftarAngka[position].suaraIndo;
		soundAngkaNum.clip = angkaManager.daftarAngka[position].suaraIndo;
		soundAngkaEng.clip = angkaManager.daftarAngka[position].suaraEng;
		// gambar.sprite = angkaManager.daftarAngka[position].gambar;
	}
	
	// Update is called once per frame
	void Update () {
		angkaNum.text = angkaManager.daftarAngka[position].angkaNum;
		angkaIndo.text = angkaManager.daftarAngka[position].angkaIndo;
		angkaEng.text = angkaManager.daftarAngka[position].angkaEng;
		soundAngkaIndo.clip = angkaManager.daftarAngka[position].suaraIndo;
		soundAngkaNum.clip = angkaManager.daftarAngka[position].suaraIndo;
		soundAngkaEng.clip = angkaManager.daftarAngka[position].suaraEng;
		// gambar.sprite = angkaManager.daftarAngka[position].gambar;
	}
}
