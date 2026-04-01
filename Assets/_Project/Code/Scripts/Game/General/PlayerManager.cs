using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerManager : MonoBehaviour
{
    [SerializeField] private InputActionReference _moveLeftAction;
    [SerializeField] private InputActionReference _moveRightAction;
    [SerializeField] private InputActionReference _selectAction;

    private int _selectedIndex = 0;
    private GameObject[] _playerTiles;


    private void OnEnable()
    {
        _moveLeftAction.action.Enable();
        _moveRightAction.action.Enable();
        _selectAction.action.Enable();

        _moveLeftAction.action.performed += OnMoveLeft;
        _moveRightAction.action.performed += OnMoveRight;
        _selectAction.action.performed += OnSelect;
    }


    private void OnDisable()
    {
        _moveLeftAction.action.performed -= OnMoveLeft;
        _moveRightAction.action.performed -= OnMoveRight;
        _selectAction.action.performed -= OnSelect;

        _moveLeftAction.action.Disable();
        _moveRightAction.action.Disable();
        _selectAction.action.Disable();
    }

    private void OnMoveLeft(InputAction.CallbackContext ctx)
    {
        _selectedIndex--;
    }

    private void OnMoveRight(InputAction.CallbackContext ctx)
    {
        _selectedIndex++;
    }


    private void OnSelect(InputAction.CallbackContext ctx)
    {
        
    }
}