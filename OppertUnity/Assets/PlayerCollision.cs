﻿using UnityEngine;

public class PlayerCollision : MonoBehaviour {

    private void OnCollisionEnter(Collision collisionInfo)
    {
        Debug.Log(collisionInfo.collider.name);

        if (collisionInfo.collider.name == "Obstacle")
        {
            
        }
    }

}
