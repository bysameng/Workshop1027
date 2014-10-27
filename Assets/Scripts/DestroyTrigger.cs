using UnityEngine;
using System.Collections;

//we'll attach this to our large cube that's below everything else
//so that we'll destroy any objects that touch it, to save memory
public class DestroyTrigger : MonoBehaviour {

	//this will be called only when the attached gameobject
	//a) has a collider with 'isTrigger' ticked
	//b) a rigidbody enters that collider
	void OnTriggerEnter(Collider other){
		Destroy(other.gameObject);
	}

}
