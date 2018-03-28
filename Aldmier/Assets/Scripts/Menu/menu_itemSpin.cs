using UnityEngine;
using System.Collections;

public class menu_itemSpin : MonoBehaviour {

    public float speed = 20f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        transform.Rotate(0, speed * Time.deltaTime, 0);
	
	}
}
