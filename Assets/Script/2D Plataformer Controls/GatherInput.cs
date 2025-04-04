using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class GatherInput : MonoBehaviour
{
    #region Inspector Reference Approach
    //public InputActionAsset actionAsset;

    //private InputActionMap playerNormal;
    //private InputAction jumpAction;
    //private InputAction moveAction;
    //private InputAction attackAction;
    #endregion

    private Controls myControls;

    public float valueX;
    public bool tryToJump;
    public bool tryToAttack;
    public bool trySpecialAttack;


    private void Awake()
    {
        myControls = new Controls();
        #region Inspector Reference Approach
        //playerNormal = actionAsset.FindActionMap("PlayerNormal");
        //jumpAction = playerNormal.FindAction("Jump");
        //moveAction = playerNormal.FindAction("MoveHorizontal");
        //attackAction = playerNormal.FindAction("Attack");
        #endregion
    }

    private void OnEnable()
    {
        //myControls.PlayerNormal.Enable();
        //myControls.PlayerNormal.Jump.Enable();
        //myControls.PlayerNormal.Jump.started += JumpStarted;
        myControls.PlayerNormal.Jump.performed += JumpExample;
        myControls.PlayerNormal.Jump.canceled += JumpStopExample;

        myControls.PlayerNormal.Attack.performed += AttackExample;
        myControls.PlayerNormal.Attack.canceled += AttackStopExample;

        myControls.PlayerNormal.SpecialAttack.performed += SpecialExample;
        myControls.PlayerNormal.SpecialAttack.canceled += StopSpecialExample;

        myControls.Enable();

        #region Inspector Reference Approach
        //jumpAction.performed += JumpExample;
        //jumpAction.canceled += JumpStopExample;

        //attackAction.performed += AttackExample;
        //attackAction.canceled += AttackStopExample;

        //actionAsset.Enable();
        //playerNormal.Enable();
        //jumpAction.Enable();
        #endregion
    }

    void Update()
    {
        valueX = myControls.PlayerNormal.MoveHorizontal.ReadValue<float>();

        if(valueX > 0.01f)
        {
            valueX = 1;
        }
        else if(valueX < 0 && valueX >= -1)
        {
            valueX = -1;
        }
        else
        {
            valueX = 0;
        }

       // Debug.Log("ValueX is: " + valueX);
    }

  /*  private void JumpStarted(InputAction.CallbackContext value)
    {
        Debug.Log("Jump started phase");
    }*/
    private void JumpExample(InputAction.CallbackContext value)
    {
        //tryToJump = value.ReadValueAsButton();
        //Debug.Log("Jump performed phase");
        tryToJump = true;
    }
    private void JumpStopExample(InputAction.CallbackContext value)
    {
        tryToJump = false;
    }

    private void AttackExample(InputAction.CallbackContext value)
    {
        tryToAttack = true;
    }
    private void AttackStopExample(InputAction.CallbackContext value)
    {
        tryToAttack = false;
    }

    private void SpecialExample(InputAction.CallbackContext value)
    {
        trySpecialAttack = true;
    //    Debug.Log("Special attack is Called");
    }
    private void StopSpecialExample(InputAction.CallbackContext value)
    {
        trySpecialAttack = false;
    }


    private void OnDisable()
    {
        //  myControls.PlayerNormal.Jump.started -= JumpStarted;
        myControls.PlayerNormal.Jump.performed -= JumpExample;
        myControls.PlayerNormal.Jump.canceled -= JumpStopExample;

        myControls.PlayerNormal.Attack.performed -= AttackExample;
        myControls.PlayerNormal.Attack.canceled -= AttackStopExample;

        myControls.PlayerNormal.SpecialAttack.performed -= SpecialExample;
        myControls.PlayerNormal.SpecialAttack.canceled -= StopSpecialExample;

        myControls.Disable();

        #region Inspector Reference Approach
        //jumpAction.performed -= JumpExample;
        //jumpAction.canceled -= JumpStopExample;

        //attackAction.performed -= AttackExample;
        //attackAction.canceled -= AttackStopExample;

        //actionAsset.Disable();
        //jumpAction.Disable();
        #endregion
    }


}
