using UnityEngine;
using System.Collections;

public class ActiveDeactive : MonoBehaviour {

	public GameObject Active;
	public GameObject Active2;
	public GameObject Deactive;
	public GameObject Deactive2;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void AD() {
		Active.SetActive (true);
		Deactive.SetActive (false);
	}
	public void D2() {
		Deactive2.SetActive (false);
	}
	public void A2() {
		Active2.SetActive (true);
	}
}
