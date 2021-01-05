using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    [SerializeField]
    private float _speed = 3f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Vector3.left = Vector3(-1,0,0)
        //Vector3.left (-1) * 1 * _speed(3) = -3
        transform.Translate(Vector3.left * Time.deltaTime * _speed);

        //check the x position of the seaweed if it is smaller then -15 
        if(transform.position.x < -15)
        {
            //teleport to 15 on the x axis
            transform.position = new Vector3(15,0,0);
        }
        
    }
}
