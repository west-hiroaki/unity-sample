using UnityEngine;

public class TapAddForceScript : MonoBehaviour {

	private Rigidbody rigid;

	void Start () {
		rigid = gameObject.GetComponent<Rigidbody> ();
	}
	
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			Debug.Log ("tap!");
			rigid.AddForce(transform.right * 500f);
		}
	}
}
