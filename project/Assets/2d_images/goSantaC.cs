using UnityEngine;
using System.Collections;


public class goSantaC : MonoBehaviour {
	void Update() {
		int fingerCount = 0;
		foreach (Touch touch in Input.touches) {
			if (touch.phase != TouchPhase.Ended && touch.phase != TouchPhase.Canceled)
				fingerCount++;
			Debug.Log (fingerCount);
		}
		
		if (fingerCount == 1)
		{
			Debug.Log("There is " + fingerCount + " finger touching the screen");
			rigidbody2D.AddForce(Vector3.right * 35);
		}else if (fingerCount ==2)
		{
			Debug.Log("There is " + fingerCount + " fingers touching the screen");
			rigidbody2D.AddForce(Vector3.up * 25);
		}else if (fingerCount ==3)
		{
			Debug.Log("There is " + fingerCount + " fingers touching the screen");
			rigidbody2D.AddForce(Vector3.left * 25);
		}
	}
}