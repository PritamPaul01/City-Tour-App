using System.Net.NetworkInformation;
using UnityEngine;

public class Movement : MonoBehaviour 
{
    CharacterController characterController;
    public float MovementSpeed= 0.5f;
    public float gravity= 9.8f;
    float yMovement;
    
    // Start is called before the first frame update
    void Start() 
    {
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal") * MovementSpeed;
        float vertical = Input.GetAxis("Vertical") * MovementSpeed;

        characterController.Move(transform.forward * vertical + transform.right * horizontal);
        if(characterController.isGrounded)
        {
            yMovement= 0;
        }
        else{
            yMovement-= gravity;
            characterController.Move(new Vector3(0, yMovement,0));
        }
    }
}
