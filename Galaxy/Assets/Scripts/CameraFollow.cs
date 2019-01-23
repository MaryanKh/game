using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    //public Transform target;
    //public float smoothTime = 0.3F;
    //private Vector3 velocity = Vector3.zero;

    public GameObject player;

    private Vector3 offset;

    // Use this for initialization
    void Start () {
        offset = transform.position - player.transform.position;
    }
	
	// Update is called once per frame
	void LateUpdate() {
        //Vector3 targetPosition = target.TransformPoint(new Vector3(0, 0, -10));
        //transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);

        //transform.position = player.transform.position + offset;
        
        if(transform.position.y < 8.6)
        {
            transform.position = new Vector3(2, player.transform.position.y, -9) + offset;
        }
        else
        {
            transform.position = new Vector3(2, 6.5f, -9) + offset;
        }
    }
}
