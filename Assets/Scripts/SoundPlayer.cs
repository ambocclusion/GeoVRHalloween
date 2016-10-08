using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class SoundPlayer : MonoBehaviour, IGvrGazeResponder {

	public bool OnClick = false;

	public AudioClip[] Sounds;

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

		int random = Random.Range(0, Sounds.Length);

		GetComponent<AudioSource>().PlayOneShot(Sounds[random]);

	}

}
