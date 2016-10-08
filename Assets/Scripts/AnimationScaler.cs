using UnityEngine;
using System.Collections;

public class AnimationScaler : MonoBehaviour {

	public float Speed = 1.0f;

	// Use this for initialization
	void Start () {
		GetComponent<Animation>()["Take 001"].speed = Speed;	
	}
	

}
