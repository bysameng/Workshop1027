using UnityEngine;
using System.Collections;

//we'll attach this to some random empty gameobject
public class Restarter : MonoBehaviour {

	// Update is called once per frame
	void Update () {

		//check when R key is pressed
		if (Input.GetKeyDown(KeyCode.R)){ 
			Application.LoadLevel(Application.loadedLevel);  //load the currently loaded level!

			//or, this is the code to load a scene
			//Application.LoadLevel("Scene1");		my scene is "Scene1.unity", so it's "Scene1"
		}

		//check when escape is pressed
		if (Input.GetKeyDown(KeyCode.Escape)){
			//quit the app! (standalone, won't work in editor)
			Application.Quit();
		}

	}
}
