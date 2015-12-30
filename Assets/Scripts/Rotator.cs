using UnityEngine;
using System.Collections;

public class Rotator : MonoBehaviour {

	private int x, y, z;

	void Start() {
		x = y = z = 45;
	}

	void Update () {
		transform.Rotate (new Vector3 (x, y, z) * Time.deltaTime);
	}
}
