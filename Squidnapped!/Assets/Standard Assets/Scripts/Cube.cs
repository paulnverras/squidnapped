using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour {

    string color_bullet;

    public Material red_cube;
    public Material blue_cube;
    public Material yellow_cube;
    public Material white_cube;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider collision)
    {

        if (collision.gameObject.name.Contains("Bullet"))
        {
            color_bullet = collision.gameObject.GetComponent<MeshRenderer>().material.name;

            switch (color_bullet)
            {
                case "red_bullet (Instance)":
                    this.GetComponent<Renderer>().material = red_cube;
                    break;
                case "blue_bullet (Instance)":
                    this.GetComponent<Renderer>().material = blue_cube;
                    break;
                case "yellow_bullet (Instance)":
                    this.GetComponent<Renderer>().material = yellow_cube;
                    break;
                case "white_bullet (Instance)":
                    this.GetComponent<Renderer>().material = white_cube;
                    break;
                default:
                    break;
            }
        }
    }
}
