using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour {

    public GameObject cradle;
    public GameObject chase;
    public GameObject camera;

    public CharacterController cc;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        cradle.transform.position = this.transform.position;
        camera.transform.position = Vector3.Lerp(camera.transform.position, chase.transform.position, 3 * Time.deltaTime);
        camera.transform.LookAt(this.transform);
        if (Input.GetMouseButton(0))
        {
            Vector2 mouseInput = new Vector2(Input.GetAxis("Mouse x"), Input.GetAxis("Mouse Y"));
            Vector3 cradleRotation = cradle.transform.eulerAngles;
            cradleRotation.y += mouseInput.x * -1f;
            cradleRotation.x += mouseInput.y;
            cradle.transform.eulerAngles = cradleRotation;
        }
	}
}
