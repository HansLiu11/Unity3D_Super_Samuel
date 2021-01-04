using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Control : MonoBehaviour {
    public float sensitivityX = 10f;
    public float sensitivityY = 10f;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButton(1))
        {
            float rotationX = Input.GetAxis("Mouse X") * sensitivityX;
            //float rotationY = Input.GetAxis("Mouse Y") * sensitivityY;
            transform.Rotate(0, rotationX, 0);
        }
        else
        {
            transform.localEulerAngles = new Vector3(0.0f, 0.0f, 0.0f);
        }
    }
}
