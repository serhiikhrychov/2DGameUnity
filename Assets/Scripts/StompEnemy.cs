using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StompEnemy : MonoBehaviour
{
    private Rigidbody2D playeRigidbody;

    public float bounceForce;

    public GameObject deathSplosion;

	// Use this for initialization
	void Start ()
	{
	    playeRigidbody = transform.parent.GetComponent<Rigidbody2D>();

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Enemy")
        {
            Destroy(other.gameObject);
            Instantiate(deathSplosion, other.transform.position, other.transform.rotation);

            playeRigidbody.velocity = new Vector3(playeRigidbody.velocity.x, bounceForce, 0f);
        }
    }
}
