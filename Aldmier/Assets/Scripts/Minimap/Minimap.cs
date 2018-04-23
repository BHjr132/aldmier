using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Minimap : MonoBehaviour {

	public Transform player;

	public Camera minimapCamera;

	public Slider minimapSlider;

	void Start () {
		minimapSlider.value = 0.5f;
	}

	void LateUpdate () {
		Vector3 newPosition = player.position;
		newPosition.y = transform.position.y;
		transform.position = newPosition;

		transform.rotation = Quaternion.Euler (90f, player.eulerAngles.y, 0f);

		minimapCamera.orthographicSize = minimapSlider.value * 25 + 15;
	}

}
