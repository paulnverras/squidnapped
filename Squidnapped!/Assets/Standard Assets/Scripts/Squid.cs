using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Squid : MonoBehaviour {

    public Material red_bullet;
    public Material blue_bullet;
    public Material yellow_bullet;
    public Material white_bullet;
    public int current_color;
    public int next_color;

    // Use this for initialization
    void Start () {
        current_color = 0;
	}
	
	// Update is called once per frame
	void Update () {
        next_color = Player.currentSquid;
        if(next_color != current_color)
        {
            switch (next_color)
            {
                case 0:
                    this.GetComponent<Renderer>().material = red_bullet;
                    break;
                case 1:
                    this.GetComponent<Renderer>().material = blue_bullet;
                    break;
                case 2:
                    this.GetComponent<Renderer>().material = yellow_bullet;
                    break;
                case 3:
                	this.GetComponent<Renderer>().material = white_bullet;
                    break;
                default:
                    break;
            }

            current_color = next_color;
        }
	}
}
