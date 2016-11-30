using UnityEngine;
using System.Collections;

public class Previous : MonoBehaviour {

	public BelajarAngka belajarAngka;
	public int inc = -1;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void prev() {
		if (belajarAngka == null) {
			return;
		}
		belajarAngka.position += inc;
		if (belajarAngka.position < 0) {
			belajarAngka.position = belajarAngka.angkaManager.daftarAngka.Length - 1;
		}
	}
}
