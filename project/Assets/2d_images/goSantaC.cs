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
		if (fingerCount == 0)
		{
			GameObject.Find("forwardrocket").renderer.enabled = false;
			GameObject.Find("downrocket").renderer.enabled = false;
			GameObject.Find("updrocket").renderer.enabled = false;
			GameObject.Find("backrocket").renderer.enabled = false;
		}
		if (fingerCount == 1)
		{
			Debug.Log("There is " + fingerCount + " finger touching the screen");
			Vector2 v2Force = 35 * transform.right;
			rigidbody2D.AddForce(v2Force);
			GameObject.Find("forwardrocket").renderer.enabled = true;
		}else if (fingerCount ==2)
		{
			Debug.Log("There is " + fingerCount + " fingers touching the screen");
			Vector2 v2Forceup = 35 * transform.up;
			rigidbody2D.AddForce(v2Forceup);
			GameObject.Find("uprocket").renderer.enabled = true;
		}else if (fingerCount ==3)
		{
			Debug.Log("There is " + fingerCount + " fingers touching the screen");
			Vector2 v2Forceleft = -35 * transform.right;
			rigidbody2D.AddForce(v2Forceleft);
			GameObject.Find("backrocket").renderer.enabled = true;
		}else if (fingerCount ==4)
		{
			Debug.Log("WOAH 4 Fingers");
			Vector2 v2Forcetop = -35 * transform.up;
			rigidbody2D.AddForce(v2Forcetop);
			GameObject.Find("downrocket").renderer.enabled = true;
		}
	}
}