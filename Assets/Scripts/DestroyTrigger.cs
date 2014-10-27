using UnityEngine;
using System.Collections;

public class DestroyTrigger : MonoBehaviour {

	void OnTriggerEnter(Collider other){
		Destroy(other.gameObject);
	}

}
