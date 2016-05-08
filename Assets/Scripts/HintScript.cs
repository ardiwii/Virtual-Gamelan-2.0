using UnityEngine;
using System.Collections.Generic;

public class HintScript : MonoBehaviour {

	public List<GameObject> cubes;
	public List<int> notes;
	public string music_notes;
	private int counter;

	// Use this for initialization
	void Start () {
		counter = 0;
	}

	public void Note_Initialize(string music_note){
		notes.Clear ();
		counter = 0;
		for (int i = 0; i < music_note.Length; i++) {
			notes.Add (int.Parse (music_note.Substring(i,1)));
		}
	}

	// Update is called once per frame
	void Update () {
		int activeCubes = notes [counter];
		for (int i = 0; i < cubes.Count; i++) {
			if (i == activeCubes) {
				cubes [i].SetActive (true);
			} else {
				cubes [i].SetActive (false);
			}
		}
	}

	public void next(){
		counter++;
	}
}
