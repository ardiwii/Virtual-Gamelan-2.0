using UnityEngine;
using System.Collections;

public class HitScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider otherCollider){
		if (otherCollider.tag == "MalletHead") {
			GameObject.FindGameObjectWithTag ("Controller").GetComponent<HintScript> ().next ();
		} 
	}
}
