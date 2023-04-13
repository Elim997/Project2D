using Pathfinding;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class Skeleton : Character, IDamageable
{

    public AIPath aiPath;
    public Transform player;

    public bool isFlipped = false;

    public void LookAtPlayer()
    {
        Vector3 flipped = transform.localScale;
        flipped.z *= -1f;
        if  (transform.position.x < player.position.x && isFlipped)
        {
            transform.localScale = flipped;
            transform.Rotate(0f, 180f, 0f);
            isFlipped = false;
        }
        else if (transform.position.x > player.position.x && !isFlipped)
        {
            transform.localScale = flipped;
            transform.Rotate(0f, 180f, 0f);
            isFlipped = true;
        }
    }
    

    void Update()
    {
        
        //HandleAnimations();
        
    }
 

   

    private void HandleAnimations()
    {
        
        if (aiPath.desiredVelocity.x != 0f)
        {
            Animator.SetFloat("Speed", Mathf.Abs(aiPath.desiredVelocity.x));
           
        }
    }



    public virtual void ApplyDamage(float amount)
    {
        CurrentHealth -= amount;
        if (CurrentHealth <= 0)
        {
            Die();
        }
    }



    
}
