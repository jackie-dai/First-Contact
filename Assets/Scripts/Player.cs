using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField]
    private float movementSpeed = 10f;

    private SpriteRenderer spriteRenderer;
    #region Animation
    private Animator animationController;
    #endregion

    void Awake()
    {
        animationController = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        ProcessMovement();
    }

    void ProcessMovement()
    {
        float inputX = Input.GetAxisRaw("Horizontal");
        float inputY = Input.GetAxisRaw("Vertical");
        
        Vector2 direction = new Vector2(inputX, inputY);
        transform.Translate(direction * Time.deltaTime * movementSpeed);
        
        animationController.SetFloat("SpeedX", inputX);
        animationController.SetFloat("SpeedY", inputY);
        if (inputX != 0 || inputY != 0)
        {

            animationController.SetBool("Walking", true);
        } else
        {
            animationController.SetBool("Walking", false);
        }
        if (inputX > 0)
        {
            transform.localScale = new Vector3(-1, transform.localScale.y, transform.localScale.z);
        }
        else
        {
            transform.localScale = new Vector3(1, transform.localScale.y, transform.localScale.z);
        }
    } 
}