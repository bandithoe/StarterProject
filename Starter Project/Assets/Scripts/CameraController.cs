using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    
    [SerializeField] private float _sensX;
    private float _mouseX;
    private float _yRotation;
    public static CameraController CamController;

    void Start()
    {
        CamController = this;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
    void Update()
    {
        _mouseX = Input.GetAxisRaw("Mouse X") * Time.deltaTime * _sensX;
        
        _yRotation += _mouseX;

        gameObject.transform.position = CurrentPlayerActive.activePlayer.gameObject.transform.position;
    }

    void LateUpdate()
    {
        transform.rotation = Quaternion.Euler(0f, _yRotation, 0f);
    }

    public void CameraSwitchPlayer(GameObject player)
    {
        transform.position = CurrentPlayerActive.activePlayer.gameObject.transform.position;
        transform.rotation = CurrentPlayerActive.activePlayer.gameObject.transform.rotation;
        _yRotation = 0f;

        
    }
}
