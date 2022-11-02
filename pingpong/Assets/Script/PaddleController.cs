using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    public int speed;
    private Rigidbody2D rig;

    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {


        // get input 
        //Vector3 movement = GetInput();
        // TODO 

        // move object
        //MoveObject(movement);
        MoveObject(GetInput());

    }
    public KeyCode upKey;
    public KeyCode downKey;
    private Vector2 GetInput()
    {
        if (Input.GetKey(upKey))
        {
            return Vector2.up * speed;
        }
        if (Input.GetKey(downKey))
        {
            return Vector2.down * speed;
        }
        return Vector2.zero;
    }

    private void MoveObject(Vector2 movement)
    {
        rig.velocity = movement;
    }
    
}
