using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Player))]
[DisallowMultipleComponent]

public class AnimatePlayer : MonoBehaviour
{ 
    private Player player;
    private void Awake()
    {
        // Load component
        player = GetComponent<Player>(); 
    }
    private void OnEnable()
    {
        // Subscribe to idle event
        player.idleEvent.OnIdle += IdleEvent_OnIdle

    }
    private void OnDisable()
    {
        // Unsubscribe to idle event
        player.idleEvent.OnIdle -= IdleEvent_OnIdle;
    }
    /// <summary>
    /// On idle event handler
    /// </summary>
    private void IdleEvent_OnIdle(IdleEvent idleEvent)
    {
        SetIdleAnimationParameters();
    }
    private void SetIdleAnimationParameters()
    {
        player.animator.SetBool(Settings.isMoving, false);

    }


}
