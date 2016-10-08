using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MultiplayerBillboard : MonoBehaviour{

	void OnWillRenderObject(){

		transform.LookAt(transform.position + Camera.current.transform.rotation * Vector3.forward,
			Camera.current.transform.rotation * Vector3.up);

	}

}
