using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class SoundPlayer : MonoBehaviour, IGvrGazeResponder {

	public bool OnClick = false;

	public AudioClip[] Sounds;

	private float _lastTime = 0.0f;
	private float _lastPlayLength = 0.0f;

	public void OnGazeEnter() {

		if(!OnClick){

			PlaySound();

		}
		
	}

	/// Called when the user stops looking on the GameObject, after OnGazeEnter
	/// was already called.
	public void OnGazeExit() {
		
	}

	/// Called when the viewer's trigger is used, between OnGazeEnter and OnGazeExit.
	public void OnGazeTrigger() {

		if(OnClick){

			PlaySound();

		}

	}

	public void PlaySound(){

		if(Time.time < _lastTime + _lastPlayLength)
			return;

		int random = Random.Range(0, Sounds.Length);

		GetComponent<AudioSource>().PlayOneShot(Sounds[random]);

		_lastTime = Time.time;
		_lastPlayLength = Sounds[random].length;

	}

}
