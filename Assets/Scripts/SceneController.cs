using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SceneController : MonoBehaviour
{
    [SerializeField] CinemachineVirtualCameraBase VCcam;
  
    [SerializeField] Button buttonExit;
    private void Awake()
    {
        buttonExit = GetComponent<Button>();
        VCcam= GetComponent<CinemachineVirtualCameraBase>();

        
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            VCcam.Priority = 0;
        }
        buttonExit.onClick.AddListener(OnClick);
    }

    void OnClick()
    {
        VCcam.Priority = 15;
    }
}
