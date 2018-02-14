using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

	public void CloseMain(){
		GameObject.Find ("Panel").transform.localScale = new Vector3(0,0,0);
	}
	public void OpenMain(){
		GameObject.Find ("Panel").transform.localScale = new Vector3(1f,1f,1f);
	}

	public void OpenCarInfo(){
		GameObject.Find ("CarInfo").transform.localScale = new Vector3(1f,1f,1f);
		CloseMain ();
	}
	public void CancelCarInfo(){
		GameObject.Find ("CarInfo").transform.localScale = new Vector3(0,0,0);
		OpenMain ();
	}

	public void OpenCarFinding(){
		GameObject.Find ("CarFinding").transform.localScale = new Vector3(1f,1f,1f);
		CloseMain ();
	}
	public void CancelCarFinding(){
		GameObject.Find ("CarFinding").transform.localScale = new Vector3(0,0,0);
		OpenMain ();
	}

	public void OpenSetting(){
		GameObject.Find ("Setting").transform.localScale = new Vector3(1f,1f,1f);
		CloseMain ();
	}
	public void CancelSetting(){
		GameObject.Find ("Setting").transform.localScale = new Vector3(0,0,0);
		OpenMain ();
	}

	public void OpenCarInfoCheck(){
		GameObject.Find ("CarInfoCheck").transform.localScale = new Vector3(1f,1f,1f);
	}
	public void CancelCarInfoChecg(){
		GameObject.Find ("CarInfoCheck").transform.localScale = new Vector3(0,0,0);
	}

	public void OpenVoice(){
		if (GameObject.Find ("voice") == null) {
			GameObject voice = (GameObject)Resources.Load ("voice") as GameObject;
			GameObject panel = GameObject.Find ("Panel");
			voice = Instantiate (voice);
			voice.transform.SetParent (panel.transform);
			voice.transform.localPosition = Vector3.zero;
			voice.name = "voice";
			if (!voice.GetComponent<AudioSource> ().isPlaying) {
				voice.GetComponent<AudioSource> ().Play ();
			}
			Destroy (voice, 5f);
		}
	}
}
