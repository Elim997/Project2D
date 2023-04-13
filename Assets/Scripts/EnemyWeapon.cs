using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWeapon : MonoBehaviour
{
    public float attackDamage = 2f;
    public int enragedAttackDamage = 40;

    private float timeUntilMeleeReadied = 0f;
    public float meleeAttackDelay = 1.1f;

    public Vector3 attackOffset;
    public float attackRange = 1f;
    public LayerMask attackMask;

    public void Attack()
    {
        Vector3 pos = transform.position;
        pos += transform.right * attackOffset.x;
        pos += transform.up * attackOffset.y;
        if (timeUntilMeleeReadied <= 0)
        {
            Collider2D colInfo = Physics2D.OverlapCircle(pos, attackRange, attackMask);
            if (colInfo != null)
            {
               // colInfo.GetComponent<Player>().ApplyDamage(attackDamage);
            }
            timeUntilMeleeReadied = meleeAttackDelay;
        }
        else
        {
            timeUntilMeleeReadied -= Time.deltaTime;
        }
    }

    

    void OnDrawGizmosSelected()
    {
        Vector3 pos = transform.position;
        pos += transform.right * attackOffset.x;
        pos += transform.up * attackOffset.y;

        Gizmos.DrawWireSphere(pos, attackRange);
    }
}