using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class DragAndDrop : MonoBehaviour {

	public Collision2D otherCollidor;

	public Vector3 screenPosition;
	public Vector3 originalPosition;

	void OnMouseDown() {
		if (transform.GetComponentInChildren<Text>().text.Trim().Length == 0)
			return;
		originalPosition = gameObject.transform.position;
		screenPosition = Camera.main.WorldToScreenPoint (gameObject.transform.position);
	}



	void OnMouseUp() {
		if (otherCollidor == null) {
			transform.position = originalPosition;
			return;
		}
		DropArea dropArea = otherCollidor.gameObject.GetComponent<DropArea> ();
		if (dropArea == null) {
			transform.position = originalPosition;
			return;
		}

		if (!dropArea.textJawaban.text.Equals (transform.GetComponentInChildren<Text> ().text)) {
			transform.position = originalPosition;
			return;
		}
			Text text = dropArea.textJawaban;
			text.color = transform.GetComponentInChildren<Text> ().color;

			transform.GetComponent<Text> ().text = "";
			transform.position = originalPosition;
	}

	void OnMouseDrag() {
		Vector3 currentScreenPosition = Vector3.zero;
#if UNITY_IPHONE || UNITY_ANDROID
		if (Input.touchCount > 0) {
			currentScreenPosition = new Vector3 (Input.GetTouch(0).position.x, Input.GetTouch(0).position.y, screenPosition.z);
		}
#endif

		#if UNITY_EDITOR
		currentScreenPosition = new Vector3 (Input.mousePosition.x, Input.mousePosition.y, screenPosition.z);
#endif
		Vector3 currentPosition = Camera.main.ScreenToWorldPoint (currentScreenPosition);
		transform.position = currentPosition;
	}

	void OnCollisionStay2D(Collision2D coll) {
		otherCollidor = coll;
	}

	void OnCollisionExit2D(Collision2D col1) {
		otherCollidor = null;
	}
}
