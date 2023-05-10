using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    public float speedRotation = 750f;

    [SerializeField] private Joystick joystick;
    private CharacterController characterController;

    private void Awake()
    {
        characterController = GetComponent<CharacterController>();
    }
    private void FixedUpdate()
    {
        Vector3 move = new Vector3(joystick.Horizontal, 0, joystick.Vertical);
        characterController.Move(move * Time.fixedDeltaTime * speed);

        if (move != Vector3.zero)
        {
            Quaternion toRotation = Quaternion.LookRotation(move, Vector3.up);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, speedRotation * Time.fixedDeltaTime);
        }
    }
}
