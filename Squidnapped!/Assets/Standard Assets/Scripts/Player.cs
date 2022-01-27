using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public GameObject bulletPrefab;
    public Camera playerCamera;
    public static int currentSquid;
    public int totalSquid;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject bulletObject = Instantiate(bulletPrefab);
            bulletObject.transform.position = playerCamera.transform.position + playerCamera.transform.forward;
            bulletObject.transform.forward = playerCamera.transform.forward;
        }

        if (Input.GetAxis("Mouse ScrollWheel") > 0f)
        {
            currentSquid = (currentSquid + 1) % totalSquid;
            
        }
        else if (Input.GetAxis("Mouse ScrollWheel") < 0f)
        {

            currentSquid = ((((currentSquid - 1) % totalSquid) + totalSquid) % totalSquid);
        }
    }
}
