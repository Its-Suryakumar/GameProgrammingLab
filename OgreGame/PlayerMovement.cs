using System.Collections;

using System.Collections.Generic;

using UnityEngine;

public class PlayerMovement : MonoBehaviour {

public float moveSpeed;

public GameObject deathParticles;

private float maxSpeed = 5f;

private Vector3 input;

private Vector3 spawn;

// Use this for initialization

void Start () {

spawn = transform.position;

}

// Update is called once per frame

void Update () {

input = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

if (GetComponent<Rigidbody>().velocity.magnitude < maxSpeed)

{

GetComponent<Rigidbody>().AddForce(input * moveSpeed);

}

if (transform.position.y < -2)

{

Die();

}

}

private void OnCollisionEnter(Collision other)

{

if(other.transform.tag == "Enemy")

{

//print("I hit enemy");

Die();

}

}

private void OnTriggerEnter(Collider other)

{

if(other.transform.tag=="Goal")

{

GameManager.CompleteLevel();

}

}

void Die()

{

Instantiate(deathParticles, transform.position, Quaternion.Euler(270,0,0));

transform.position = spawn;

}

}