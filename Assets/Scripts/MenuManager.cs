using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;

public class MenuManager : MonoBehaviour
{
    
    [SerializeField] CinemachineVirtualCameraBase arrayVCcam;

   public  void TurnOnOff(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            arrayVCcam.gameObject.SetActive(false);
        }
    }

    
}
