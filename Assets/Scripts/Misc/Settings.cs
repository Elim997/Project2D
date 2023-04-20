using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public static class Settings
{
    #region ANIMATOR PARAMETERS
    // Animator parameters - Player
    public static int isIdle = Animator.StringToHash("isIdle");
    public static int isMoving = Animator.StringToHash("isMoving");
    public static int rollRight = Animator.StringToHash("rollRight");
    public static int use = Animator.StringToHash("use");
    public static float baseSpeedForPlayerAnimations = 8f;

    // Animator parameters - Enemy
    public static float baseSpeedForEnemyAnimations = 3f;
    // Animator parameters - DamageableDecoration
   // public static int destroy = Animator.StringToHash("destroy");
    //public static String stateDestroyed = "Destroyed";

    #endregion

    #region GAMEOBJECT TAGS
    public const string playerTag = "Player";
    public const string playerWeapon = "playerWeapon";
    #endregion

    #region AUDIO
    public const float musicFadeOutTime = 0.5f;  // Defualt Music Fade Out Transition
    public const float musicFadeInTime = 0.5f;  // Default Music Fade In Transition
    #endregion

    #region ASTAR PATHFINDING PARAMETERS
    public const int defaultAStarMovementPenalty = 40;
    public const int preferredPathAStarMovementPenalty = 1;
    public const int targetFrameRateToSpreadPathfindingOver = 60;
    public const float playerMoveDistanceToRebuildPath = 3f;
    public const float enemyPathRebuildCooldown = 2f;

    #endregion

    #region ENEMY PARAMETERS
    public const int defaultEnemyHealth = 20;
    #endregion

    #region UI PARAMETERS
    public const float uiHeartSpacing = 16f;
    public const float uiAmmoIconSpacing = 4f;
    #endregion

    #region CONTACT DAMAGE PARAMETERS
    public const float contactDamageCollisionResetDelay = 0.5f;
    #endregion

    #region HIGHSCORES
    public const int numberOfHighScoresToSave = 100;
    #endregion
}
