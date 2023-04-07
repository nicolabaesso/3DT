using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour{
    public float speed;
    private Vector2 move;
    public Rigidbody rb;
    private float gravityScale=10;

    public void OnMove(InputAction.CallbackContext context){
        move=context.ReadValue<Vector2>();
    }

    public void OnJump(InputAction.CallbackContext context){
        gravityScale=-1*context.ReadValue<float>();
    }

    // Start is called before the first frame update
    void Start(){
    }

    // Update is called once per frame
    void Update(){
        movePlayer();
        jumpPlayer();
    }
    
    public void movePlayer(){
        Vector3 movement=new Vector3(move.x, 0f, move.y);
        transform.Translate(movement * speed * Time.deltaTime, Space.World);
    }

    public void jumpPlayer(){
        rb.AddForce(Physics.gravity * (gravityScale) * rb.mass);
    }
}
