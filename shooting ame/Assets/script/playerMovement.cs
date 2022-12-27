using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public float moveSpeed = 5f;
    private Animator playerAnimator;
    private float verticalValue;
    public Vector3 playerToMouse;
    public Ray cameraRay;
    public RaycastHit groundHit;
    public Quaternion newRotaion ; 



    private void Awake()
    {
        
        playerAnimator=GetComponent<Animator>();
            
    }
    private void Update()
    {
        verticalValue = Input.GetAxisRaw("Vertical");
        Move();
        Turn();

    }

private void Move()
{
    if(verticalValue != 0)
        {
            playerAnimator.SetBool("running", true);
            playerAnimator.SetFloat("Direction", verticalValue);
            transform.position = transform.position + verticalValue*transform.forward* moveSpeed*Time.deltaTime; 
        }
    else
        {
            playerAnimator.SetBool("running", false);
        }
    }
private void Turn() { 
 cameraRay = Camera.main.ScreenPointToRay(Input.mousePosition);
       
            if (Physics.Raycast(cameraRay,out groundHit, Mathf.Infinity))
        {
            playerToMouse  = groundHit.point - transform.position;
            playerToMouse.y = 0 ;
            newRotaion = Quaternion.LookRotation(playerToMouse);
            transform.rotation = newRotaion;
             
                
        }
}
}