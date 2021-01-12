using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    [SerializeField]
    private float _speed = 3f;
    [SerializeField]
    private bool _randomizeHeight = true;
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
            if(_randomizeHeight)
            {
                float randomYPosition = Random.Range(-3f,3f);
                Debug.Log("The random position is: " + randomYPosition);
                //teleport to 15 on the x axis
                transform.position = new Vector3(15,randomYPosition,0);
            }
            else
            {
                transform.position = new Vector3(15,transform.position.y,transform.position.z);
            }
        }
        
    }
}
