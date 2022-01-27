using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class InkBullet : MonoBehaviour {
    public float bullut_speed = 20f;
    public float time_limit;

    public Material red_bullet;
    public Material blue_bullet;
    public Material yellow_bullet;
    public Material white_bullet;

    public GameObject player;

    // Use this for initialization
    void Start () {

        switch (Player.currentSquid)
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
    }
	
	// Update is called once per frame
	void Update () {
        transform.position += transform.forward * bullut_speed * Time.deltaTime;
        time_limit -= Time.deltaTime;
        if(time_limit <= 0f)
        {

            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider collision)
    {

        if (collision.gameObject.name.Contains("Cube"))
        {
            Destroy(gameObject);
        }
    }
}
