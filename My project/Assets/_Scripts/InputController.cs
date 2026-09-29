using UnityEngine;
using UnityEngine.InputSystem;

public class InputController : MonoBehaviour
{
    public static InputController Instance;
    InputAction shootInput;
    InputAction movementInput;
    InputAction shootInput;

    [HideInInspector] public Vector2 movementVector;

    private void Awake()
    {
       if (Instance == null)
        {
            Instance = this;
        }
       else
        {
            Destroy(this);
        }

        movementInput = InputSystem.actions.FindAction("Move");
        shootInput = InputSystem.actions.FindAction("Attack");
    }

    // Update is called once per frame
    void Update()
    {
        GetMoveInput();
        Shoot();
<<<<<<< HEAD
=======
    }

    private void Shoot()
    {
        if (shootInput.WasPressedThisFrame())
        {
            GunController.Instance.Fire();
        }
>>>>>>> d61501eb9f13a49e72f606c921b5c9cf4f4cc923
    }

    public void GetMoveInput()
    {
        movementVector = movementInput.ReadValue<Vector2>();
    }
    public void Shoot()
    {
        if (shootInput.WasPressedThisFrame())
        {
            GunController.Instance.Fire();
        }
    }
}
