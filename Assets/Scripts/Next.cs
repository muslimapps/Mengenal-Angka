using UnityEngine;
using System.Collections;

public class Next : MonoBehaviour {

	public BelajarAngka belajarAngka;
	public int inc = 1;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void next() {
		if (belajarAngka == null) {
			return;
		}
		belajarAngka.position += inc;
		if (belajarAngka.position >= belajarAngka.angkaManager.daftarAngka.Length) {
			belajarAngka.position = 0;
		}
	}
}
