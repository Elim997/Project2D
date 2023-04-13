using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = " PlayerDetaile ", menuName = " Scriptable Object/Player/Player Details")]

public class PlayerDetailsSO : ScriptableObject
{

    #region Header PLAYER BASE DETAILS
    [Space(10)]
    [Header(" PLAYER BASE DETAILS")]
    #endregion
    public string playerCharcterName;

    #region Tooltip
    [Tooltip("Prefab gameobject for the player")]

    #endregion
    public GameObject playerPrefab;

    #region Tooltip
    [Tooltip("Player runtime animator controller")]
    #endregion
    public RuntimeAnimatorController runtimeAnimatorController;

    #region Header HEALTH
    [Space(10)]
    [Header("HEALTH")]
    #endregion
    #region Tooltip
    [Tooltip("plaer starting hleath amount")]
    #endregion
    public int playerHealthAmount;

    #region Validation
#if UNITY_EDITOR
    private void OnValidate()
    {
        HelperUtilities.ValidateCheckEmptyString(this, nameof(playerCharcterName), playerCharcterName);
        HelperUtilities.ValidateCheckNullValue(this, nameof(playerPrefab), playerPrefab);
        HelperUtilities.ValidateCheckPositiveValue(this,nameof(playerHealthAmount), playerHealthAmount,false);
        HelperUtilities.ValidateCheckNullValue(this, nameof(runtimeAnimatorController), runtimeAnimatorController);


    }
#endif
    #endregion


}
