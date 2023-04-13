using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class HelperUtilities
{
    public static Camera mainCamera;
    /// <summary>
    /// Get the mouse World Position
    /// </summary>
   
    public static Vector3 GetMouseWorldPosition()
    { if (mainCamera == null) mainCamera = Camera.main; 
      Vector3 mouseScreenPosition=Input.mousePosition;
      
      //clamp mouse position to screen size 
      mouseScreenPosition.x = Mathf.Clamp(mouseScreenPosition.x, 0f, Screen.width);
      mouseScreenPosition.y = Mathf.Clamp(mouseScreenPosition.y, 0f, Screen.height);
      Vector3 worldPosition = mainCamera.WorldToScreenPoint(mouseScreenPosition);
      worldPosition.z=0f;
    
      return worldPosition;
    }
    /// <summary>
    /// Get the angle in degrees from a dirction vector
    /// </summary>
    public static float GetAngleFromVector(Vector3 vector)
    {
        float radian = Mathf.Atan2(vector.x, vector.y);
        float degrees = radian*Mathf.Rad2Deg;
        return degrees;
    }
    /// <summary>
    /// Get aimDirection enum value from pased in angleDegrees
    /// </summary>
    public static AimDirection GetAimDirection(float angleDegrees)
    {
        AimDirection aimDirection;
        if(angleDegrees>=22f && angleDegrees <= 67f) 
        {
            aimDirection= AimDirection.UpRight;
        }
        else if(angleDegrees > 67f && angleDegrees <= 112f)
        {
            aimDirection = AimDirection.Up;
        }
        else if (angleDegrees > 112f && angleDegrees <= 158f)
        {
            aimDirection = AimDirection.UpLeft;
        }
        else if ((angleDegrees > 158f && angleDegrees <= 180f) || (angleDegrees > -180f && angleDegrees <= -135f))
        {
            aimDirection = AimDirection.Left;
        }
        else if (angleDegrees > -135f && angleDegrees <= -45f)
        {
            aimDirection = AimDirection.UpLeft;
        }
        else
        {
            aimDirection = AimDirection.Right;
        }
        return aimDirection;
    }
    public static bool ValidateCheckEmptyString(Object thisObject, string fieldName, string stringToCheck)
    {
        if (stringToCheck == "")
        {
            Debug.Log(fieldName + " is empty and must contain a value in object " + thisObject.name.ToString());
            return true;
        }
        return false;
    }


    public static bool ValidateCheckNullValue(Object thisObject, string fieldName, UnityEngine.Object objectToCheck)
    {
        if (objectToCheck == null)
        {
            Debug.Log(fieldName + " is null and must contain a value in object " + thisObject.name.ToString());
            return true;
        }
        return false;
    }

    public static bool ValidateCheckEnumerableValues(Object thisObject, string fieldName, IEnumerable enumerableObjectToCheck)
    {
        bool error = false;
        int count = 0;

        if (enumerableObjectToCheck == null)
        {
            Debug.Log(fieldName + " is null in object " + thisObject.name.ToString());
            return true;
        }

        foreach (var item in enumerableObjectToCheck)
        {
            if (item ==null)
            {
                Debug.Log(fieldName + " has null values in object " + thisObject.name.ToString());
                error = true;
            }
            else
            {
                count++;
            }
        }

        if (count == 0)
        {
            Debug.Log(fieldName + " has no values in object " + thisObject.name.ToString());
            error = true;
        }
        return error;
    }
    public static bool ValidateCheckPositiveValue(Object thisObject , string fieldName, int valueToCheck, bool isZeroAllowd)
    {
        bool error = false;
        if (isZeroAllowd)
        {
            if (valueToCheck < 0)
            {
                Debug.Log(fieldName + " Must contain a positive value or zero in object " + thisObject.name.ToString());
                error=true;
            }
            else
            {
                if (valueToCheck <= 0)
                {
                    Debug.Log(fieldName + " Must contain a positive value  in object " + thisObject.name.ToString());
                    error = true;
                }
            }
        }
        return error;
    }


}
