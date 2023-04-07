using UnityEngine;

public class PlayerCollision : MonoBehaviour{

    public PlayerController controller;

    void OnCollisionEnter(Collision collisionInfo){
        //Debug.Log(collisionInfo.collider.name);
    }
}
