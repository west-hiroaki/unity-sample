using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour {

	void OnCollisionEnter(Collision collision){
		Debug.Log ("crush! " + collision.gameObject.name);

		if (collision.gameObject.tag == "Player") {
			Destroy (this.gameObject);
		}
	}
}
