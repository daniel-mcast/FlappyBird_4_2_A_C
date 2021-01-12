using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundScroller : MonoBehaviour
{
    [SerializeField]
    private float _scrollSpeed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Find the current offset of the texture
        Vector2 currentTextureOffset = this.GetComponent<Renderer>().material.GetTextureOffset("_MainTex");
        //Determine the amount of movement applied on the texture
        float distanceToScrollLeft = Time.deltaTime * _scrollSpeed;
        //Calculate the new offset of the x axis
        float newTextureOffset_X = currentTextureOffset.x + distanceToScrollLeft;
        //Change original position or increment the original position
        currentTextureOffset = new Vector2(newTextureOffset_X,currentTextureOffset.y);
        //Set the new offset to the texture
        this.GetComponent<Renderer>().material.SetTextureOffset("_MainTex",currentTextureOffset);
    }
}
