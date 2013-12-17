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
			Vector2 v2Force = 35 * transform.right;
			rigidbody2D.AddForce(v2Force);
		}else if (fingerCount ==2)
		{
			Debug.Log("There is " + fingerCount + " fingers touching the screen");
			Vector2 v2Forceup = 35 * transform.up;
			rigidbody2D.AddForce(v2Forceup);
		}else if (fingerCount ==3)
		{
			Debug.Log("There is " + fingerCount + " fingers touching the screen");
			Vector2 v2Forceleft = -35 * transform.right;
			rigidbody2D.AddForce(v2Forceleft);
		}
	}
}