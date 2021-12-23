using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingThePlatform : MonoBehaviour
{
    // Start is called before the first frame update
    private float startX;
    private float startY;
    public float movementSpeed = 1f;
    public int numberOfTilesToMoveX = 5;
    private bool goingRight = true;
    void Start()
    {
        startX = this.transform.position.x;
        startY = this.transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        MoveThePlatform();
    }

    private void MoveThePlatform()
    {

        if (this.transform.position.x - startX >= numberOfTilesToMoveX)
        {
            goingRight = false;
            //transform.Translate(-movementSpeed * Time.deltaTime, 0, 0);
        }
        if (startX-this.transform.position.x >= numberOfTilesToMoveX)
        {
            goingRight = true;
            //transform.Translate(-movementSpeed * Time.deltaTime, 0, 0);
        }
        if (goingRight)
        {
            transform.Translate(movementSpeed * Time.deltaTime, 0, 0);
        }
        if (!goingRight)
        {
            transform.Translate(-movementSpeed * Time.deltaTime, 0, 0);
        }
    }
}
