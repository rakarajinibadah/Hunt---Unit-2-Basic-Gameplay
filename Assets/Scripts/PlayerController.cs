using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
    public float speed = 10.0f;
    public float xRange = 10;
    public GameObject projectilePrefab;

    //private const string HORIZONTAL = "Horizontal";

    //private const string VERTICAL = "Vertical";

    private float horizontalInput; 
    //private float verticalInput;

    //Mobile
    //public FixedJoystick joystickHorizontal;
    //public FixedJoystick shotProjectile;


    private void FixedUpdate()
    {
        //GetInput();

    }

    public void GetInput()
    {
        //horizontalInput = Input.GetAxis(HORIZONTAL);
        //verticalInput = Input.GetAxis(VERTICAL);

       // horizontalInput = joystickHorizontal.Horizontal;
       // verticalInput = shotProjectile.Vertical;
    }

    // Update is called once per frame
    void Update()
    {
        //Keeping the player inbounds
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        //ShotBullet();
        //horizontalInput.ToString();

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
    }

   

    
    void ShotBullet()
    {
        //if(verticalInput != 0)
        //{
           // Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
            
        //}
       
    }



}
