using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	public GameObject player;

	private Vector3 offset;
	float cameraHeightSpeed = 1;
	float timeStart;
	float timeEnd;

	// Use this for initialization
	void Start () {
		offset = transform.position - player.transform.position;	
		UnityEngine.Camera.main.orthographicSize = 6;
		timeStart= Time.time;
	}
	
	// Update is called once per frame
	void LateUpdate () {
		transform.position = player.transform.position + offset;
		timeEnd = Time.time + 1;
		//print (Mathf.Floor((timeEnd - timeStart)%5));
		if (Mathf.Floor((timeEnd - timeStart) % 5) == 0) {
			cameraHeightSpeed += (float)(0.01);
			
		}

		UnityEngine.Camera.main.orthographicSize += cameraHeightSpeed * Time.deltaTime;
		
		//UnityEngine.Camera.main.orthographicSize
	}

	/*void cameraHeight(){
		came
	}
	CamHover*/
}
