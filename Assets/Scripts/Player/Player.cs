using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;
#region REQUIRE COMPONENTS
[RequireComponent(typeof(Health))]
[RequireComponent(typeof(IdleEvent))]
[RequireComponent(typeof(SortingGroup))]
[RequireComponent(typeof(SpriteRenderer))]
[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(BoxCollider2D))]
[RequireComponent(typeof(PolygonCollider2D))]
[RequireComponent(typeof(Rigidbody2D))]
[DisallowMultipleComponent]
#endregion REQUIRE COMPONENTS

public class Player : MonoBehaviour

{
    [HideInInspector] public PlayerDetailsSO PlayerDetails;
    [HideInInspector] public Health health;
    [HideInInspector] public IdleEvent idleEvent;
    [HideInInspector] public SpriteRenderer spriteRenderer;
    [HideInInspector] public Animator animator;


    private void Awake()
    {
        ///Load component
        health = GetComponent<Health>();
        idleEvent= GetComponent<IdleEvent>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
    }
    /// <summary>
    /// Initialize the player
    /// </summary>
    /// <param name="playerDetails"></param>
    public void Initialize(PlayerDetailsSO playerDetails)
    {
        this.PlayerDetails = playerDetails;
        SetPlayerHealth();
    }
    private void SetPlayerHealth()
    {
        health.SetStartingHealth(PlayerDetails.playerHealthAmount);
    }
    public IdleEvent GetIdleEvent()
    { return IdleEvent; }


}
