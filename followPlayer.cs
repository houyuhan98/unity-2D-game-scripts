using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followPlayer : MonoBehaviour {
    public Transform Character;
    public float speed = 0.1F; // Enemy speed
    private Vector3 directionOfCharacter;
   
    void Update()
    {
            directionOfCharacter = Character.transform.position - transform.position;
            directionOfCharacter = directionOfCharacter.normalized;    // Get Direction to Move Towards
            transform.Translate(directionOfCharacter * speed, Space.World);
      
    }
    // Will be triggered as soon as player would touch the Enemy Object
    
}
