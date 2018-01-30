using UnityEngine;
using System.Collections;

public class MusicPlayer : MonoBehaviour {

	private static MusicPlayer instance;
	
	// Use this for initialization
	
	void Awake(){		
		if(instance == null){
			GameObject.DontDestroyOnLoad(gameObject);
			instance = this;
		}
		else {
			Destroy(gameObject);
			print ("Duplicate music player destroyed");
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
