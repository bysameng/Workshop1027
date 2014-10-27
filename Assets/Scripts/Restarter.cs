using UnityEngine;
using System.Collections;

public class Restarter : MonoBehaviour {

	// Update is called once per frame
	void Update () {

		//check when R key is pressed
		if (Input.GetKeyDown(KeyCode.R)){ 
			Application.LoadLevel(Application.loadedLevel);  //load the currently loaded level!

			//load a scene
			//Application.LoadLevel("Scene1");		my scene is "Scene1.unity", so it's "Scene1"
		}

		//check when escape is pressed
		if (Input.GetKeyDown(KeyCode.Escape)){
			Application.Quit();
		}

	}
}
