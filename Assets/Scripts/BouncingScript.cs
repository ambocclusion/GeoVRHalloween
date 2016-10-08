using UnityEngine;
using System.Collections;

public class BouncingScript : MonoBehaviour {

	public Vector3 PosScale = new Vector3(0,0,0);
	public Vector3 RotScale = new Vector3(0,0,0);

	public float PosSpeed = 1.0f;
	public float RotSpeed = 1.0f;

	private float _posAngle = 0.0f;
	private float _rotAngle = 0.0f;

	private Vector3 _startPos;
	private Vector3 _startRot;

	void Awake(){

		_startPos = transform.position;
		_startRot = transform.eulerAngles;

	}

	void Update(){

		_posAngle += PosSpeed * Time.deltaTime;
		transform.position = _startPos + (PosScale * Mathf.Sin(_posAngle));

		_rotAngle += RotSpeed * Time.deltaTime;
		transform.eulerAngles = (RotScale * Mathf.Sin(_rotAngle));		

	}

}
