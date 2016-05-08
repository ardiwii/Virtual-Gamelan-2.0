using UnityEngine;
using System.Collections;

public class SaronVoice : MonoBehaviour {

	AudioSource note;

	// Use this for initialization
	void Start () {
		note = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider otherCollider){
		if (otherCollider.tag == "MalletHead") {
			note.Play ();
		} else {
			note.Stop ();
		}
	}
}
