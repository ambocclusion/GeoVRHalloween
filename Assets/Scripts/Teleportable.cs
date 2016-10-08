using UnityEngine;
using System.Collections;

public class Teleportable : MonoBehaviour, IGvrGazeResponder {

	public float FloorOffset = 1.0f;

	/// Called when the user is looking on a GameObject with this script,
	/// as long as it is set to an appropriate layer (see GvrGaze).

	void LateUpdate(){

		GvrViewer.Instance.UpdateState();
		
	}

	public void OnGazeEnter() {


		
	}

	/// Called when the user stops looking on the GameObject, after OnGazeEnter
	/// was already called.
	public void OnGazeExit() {
		
	}

	/// Called when the viewer's trigger is used, between OnGazeEnter and OnGazeExit.
	public void OnGazeTrigger() {
		RaycastHit hit;
		Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit);
		Teleport(hit.point);
	}

	public void Teleport(Vector3 location){
		Camera.main.transform.position = location + new Vector3(0, FloorOffset, 0);
	}

}
