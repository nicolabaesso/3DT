using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour{
    public float speed;
    private Vector2 moveDirection;
    public Rigidbody rb;
    private float gravityScale=0;
    public Playerinputs playerControls;
    private InputAction jmp;
    private InputAction move;
    private bool isjumping;
    public float jumpForce=5;


    public void OnMove(InputAction.CallbackContext context){
        moveDirection=move.ReadValue<Vector2>();
    }

    public void OnJump(InputAction.CallbackContext context){
        gravityScale=-1*context.ReadValue<float>();
    }

    private void Awake(){
        playerControls=new Playerinputs();
    }

    private void OnEnable(){
        jmp=playerControls.Player.Jump;
        jmp.Enable();
        move=playerControls.Player.Movements;
        move.Enable();
    }

    private void OnDisable(){
        jmp.Disable();
        move.Disable();
    }

    // Start is called before the first frame update
    void Start(){
    }

    // Update is called once per frame
    void Update(){
        movePlayer();
        if(isJumpPressed() && !isjumping){
            jumpPlayer();
            isjumping=true;
        }
    }
    
    public void movePlayer(){
        Vector3 movement=new Vector3(moveDirection.x, 0f, moveDirection.y);
        transform.Translate(movement * speed * Time.deltaTime, Space.World);
    }

    private void jump(InputAction.CallbackContext ctx){
        jumpPlayer();
    }

    public void jumpPlayer(){
        //rb.AddForce(Physics.gravity * (gravityScale*1.5f) * rb.mass);
        rb.velocity=Vector3.up*jumpForce;
    }

    private bool isJumpPressed(){
        return Input.GetButtonDown("Jump");
    }

    private void OnCollisionEnter(Collision collisionInfo){
        if(collisionInfo.collider.tag=="Ground" || collisionInfo.collider.tag=="Cube"){
            isjumping=false;
        }
    }
}
