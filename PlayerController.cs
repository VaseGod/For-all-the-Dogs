using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 10.0f;
    public float xRange = 13.0f;

    public GameObject projectilePrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Keeps the Player Inbounds
        if(transform.position.x < -xRange)
        {
            transform.position = new UnityEngine.Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new UnityEngine.Vector3(xRange, transform.position.y, transform.position.z);
        }
        //Gets Horizontal Input from User
        horizontalInput = Input.GetAxis("Horizontal");
        //Moves Player horizontally 
        transform.Translate(UnityEngine.Vector3.right * horizontalInput * Time.deltaTime * speed);

        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }
}
