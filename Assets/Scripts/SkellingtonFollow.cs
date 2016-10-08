using UnityEngine;
using System.Collections;

public class SkellingtonFollow : MonoBehaviour {

	public float Speed = 5.0f;
	public float RandomRange = .5f;

	private Vector3 _randomoffset;

	private float _timeSinceLastChange = 0.0f;

	// Use this for initialization
	void Start () {

		_randomoffset = new Vector3(Random.Range(-.5f, .5f), -.75f, Random.Range(-.5f, .5f));
	
	}
	
	// Update is called once per frame
	void Update () {

		transform.position = Vector3.Lerp(transform.position, Camera.main.transform.position + _randomoffset, Speed * Time.deltaTime);

		if(Time.time >= _timeSinceLastChange + 5.0f){
			_randomoffset = new Vector3(Random.Range(-RandomRange, RandomRange), -.75f, Random.Range(-RandomRange, RandomRange));
			_timeSinceLastChange = Time.time;
		}
	
	}
}
