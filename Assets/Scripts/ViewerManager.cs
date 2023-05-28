using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewerManager : MonoBehaviour
{
    [SerializeField] float speed;

    private Vector3 CurrentPosition;

    // Start is called before the first frame update
    void Update()
    {
        Movement();
    }

    // Update is called once per frame
    void Movement()
    {
        //updates on each change
        //check if button is pushed
        //if w -> front, a-> left, etc
        //float xDirection = Input.GetAxis("Horizontal");
        //float yDirection = Input.GetAxis("Vertical");
        if (Input.GetKey(KeyCode.S)) CurrentPosition.z += speed * Time.deltaTime;
        if (Input.GetKey(KeyCode.W)) CurrentPosition.z -= speed * Time.deltaTime;
        if (Input.GetKey(KeyCode.A)) CurrentPosition.x += speed * Time.deltaTime;
        if (Input.GetKey(KeyCode.D)) CurrentPosition.x -= speed * Time.deltaTime;
        if (Input.GetKey(KeyCode.DownArrow)) CurrentPosition.y -= speed * Time.deltaTime;
        if (Input.GetKey(KeyCode.UpArrow)) CurrentPosition.y += speed * Time.deltaTime;

        transform.position = CurrentPosition;

    }
}
