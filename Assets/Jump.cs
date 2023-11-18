using System;
using UnityEngine;
using UnityEngine.InputSystem;

// Referenced physics used here: https://gamedev.stackexchange.com/questions/70268/can-someone-explain-flappy-birds-physics-to-me
public class Jump : MonoBehaviour
{
    [SerializeField] private InputActionReference jumpButton;
    [SerializeField] private float fallingConstant = 2.0f;
    [SerializeField] private float jumpSpeed = 0f;


    private float vertSpeed = 0f;
    private CharacterController _characterController;
    private Vector3 _playerVelocity;

    private void Awake() => _characterController = GetComponent<CharacterController>();

    private void OnEnable() => jumpButton.action.performed += Jumping;

    private void OnDisable() => jumpButton.action.performed -= Jumping;

    private void Jumping(InputAction.CallbackContext obj)
    {
        _playerVelocity.y = jumpSpeed;
    }

    private void Update()
    {
        _playerVelocity.y -= fallingConstant * Time.deltaTime;
        _characterController.Move(_playerVelocity * Time.deltaTime);
    }
}