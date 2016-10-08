using UnityEngine;
using System.Collections;

public class AnimationScaler : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GetComponent<Animation>()["Take 001"].speed = .29f;	
	}
	

}
