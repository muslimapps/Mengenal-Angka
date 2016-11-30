using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SoalPasangAngka : MonoBehaviour {

	public AngkaManager angkaManager;

	public Text[] rendererDragPilihan;
	public Text[] rendererDropJawaban;

	public int jumlahSoal;

	public bool acakSoal;

	void OnEnable () {

			jumlahSoal = 0;

			int[] dropJawaban = new int[5];

			dropJawaban [0] = Random.Range (0, 9);
			dropJawaban [1] = dropJawaban [0];
			while (dropJawaban [1] == dropJawaban [0]) {
				dropJawaban [1] = Random.Range (0, 9);
			}

			dropJawaban [2] = dropJawaban [0];
			while (dropJawaban [2] == dropJawaban [1] || dropJawaban [2] == dropJawaban [0]) {
				dropJawaban [2] = Random.Range (0, 9);
			}
			dropJawaban [3] = dropJawaban [0];
			while (dropJawaban [3] == dropJawaban [1] || dropJawaban [3] == dropJawaban [0] || dropJawaban [3] == dropJawaban [2]) {
				dropJawaban [3] = Random.Range (0, 9);
			}
			dropJawaban [4] = dropJawaban [0];
			while (dropJawaban [4] == dropJawaban [1] || dropJawaban [4] == dropJawaban [0] || dropJawaban [4] == dropJawaban [2] || dropJawaban [4] == dropJawaban [3]) {
				dropJawaban [4] = Random.Range (0, 9);
			}

			int[] dragPilihan = new int[5];
			for (int i = 0; i < dragPilihan.Length; i++) {
				dragPilihan [i] = dropJawaban [i];
			}

		for (int i = 0; i < rendererDragPilihan.Length; i++) {
			rendererDragPilihan [i].text = angkaManager.daftarAngka [dragPilihan[i]].angkaNum;
		}

		for (int i = 0; i < dropJawaban.Length; i++) {
			rendererDropJawaban [i].text = rendererDragPilihan [i].text;
		}
	}

	void Update () {
		if (acakSoal) {
			this.OnEnable ();
			acakSoal = false;
		}


	}
}
