using UnityEngine;
using System.Collections;

//throws spheres!
public class SphereThrower : MonoBehaviour 
{
	//this field will show up in the inspector since
	//a) its type (gameobject) is supported by Unity's inspector 
	//b) it's a public field (private fields won't show up)
	public GameObject sphereObject;

	//other field types that work: try them out:
	//float, int, string, Color, Transform, or ANY SCRIPT TYPE!
	//for example, these will show up in the inspector.
//	public float speed;
//	public Light myLight;

	// Use this for initialization
	void Start () {
		//if you wanna take comments or notes you can do it inline like this
		// by using double forward slashes -> //
		Debug.Log("hello plug");
	}


	// Update is called once per frame
	void Update () {

		//spacing for clarity
		if (   Input.GetKeyDown(KeyCode.Space)   )
		{
			//space was pressed!
			Debug.Log("space was pressed!!!!");

			//let's spawn a sphere!
			GameObject sphereInstance; //a variable that can hold a gameobject
			//instantiate the blueprint and then assign the instance to our variable
			sphereInstance = (GameObject)Instantiate(sphereObject, 
			                                         transform.position, 
			                                         transform.rotation);
			//then let's throw it by adding force
			Vector3 force; //declaring a new variable that holds a vector3
			force = this.transform.forward * 3000f;
			sphereInstance.rigidbody.AddForce(force); //add that force to its rigidbody!

			//destroy the sphere in 10 seconds
//			Destroy(sphereInstance, 10f);
		}
		Vector3 movement = new Vector3(0, 0, 0);

		if (Input.GetKey(KeyCode.W)){ 								//change key to W
			movement = movement + this.transform.up; 				//now move in UP direction (y axis)
		}
		if (Input.GetKey(KeyCode.A)){
			movement = movement - this.transform.right;
		}
		if (Input.GetKey(KeyCode.S)){ 								//S key, down
			movement = movement - this.transform.up; 				//negative UP direction (down, or -y)
		}
		if (Input.GetKey(KeyCode.D)){ 								//change key to D
			movement = movement + this.transform.right; 			//change movement - to movement +
		}

		//scale movement and then translate
		movement = movement * 3f;
		this.transform.parent.Translate(movement * Time.deltaTime);
	}

}