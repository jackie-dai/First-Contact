using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class PlayerController : MonoBehaviour
{
    public static PlayerController playerController;
    #region Movement_vars
    public Transform playerTransform;
    public GameObject map;
    public float movespeed;
    float x_input;
    float y_input;
    Vector2 currDirection;
    #endregion

    #region Cam_vars
    Camera cc_camera;
    float mapWidth;
    float mapHeight;
    float camWidth;
    float camHeight;
    Vector3 mapPosition;
    #endregion

    #region Physics_components
    Rigidbody2D PlayerRB;
    #endregion

    #region UI_var
    public GameObject UIPrefab;
    #endregion

    #region Interaction Var
    bool onDoor;
    #endregion 

    #region Unity_functions
    private void Awake()
    {
        playerController = this;
        mapWidth = map.GetComponent<SpriteRenderer>().bounds.size.x;
        mapHeight = map.GetComponent<SpriteRenderer>().bounds.size.y;
        mapPosition = map.transform.position;

        cc_camera = Camera.main;
        camHeight = 2 * cc_camera.orthographicSize;
        camWidth = cc_camera.aspect * camHeight;

        PlayerRB = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetKeyDown("tab"))
        {
            this.gameObject.SetActive(false);
            SceneManager.LoadScene("Disguise", LoadSceneMode.Additive);
        }

        if (onDoor && Input.GetKeyDown("e"))
        {
            SceneManager.LoadScene("dialogue");
        }

        x_input = Input.GetAxisRaw("Horizontal");
        y_input = Input.GetAxisRaw("Vertical");

        Move();
        CamMove();
    }
    #endregion

    #region Movement_funcs
    private void Move()
    {
        if (x_input > 0)
        {
            PlayerRB.velocity = Vector2.right * movespeed;
            currDirection = Vector2.right;

        } else if (x_input < 0)
        {
            PlayerRB.velocity = Vector2.left * movespeed;
            currDirection = Vector2.left;

        }

        else if (y_input > 0)
        {
            PlayerRB.velocity = Vector2.up * movespeed;
            currDirection = Vector2.up;

        }
        else if (y_input < 0)
        {
            PlayerRB.velocity = Vector2.down * movespeed;
            currDirection = Vector2.down;

        } 
        else
        {
            PlayerRB.velocity = Vector2.zero;
        }
    }
    #endregion

    #region Camera Movements
    public void CamMove()
    {
        Vector3 newPos;
        Vector3 playerPos = transform.position;
        newPos = playerPos;
        if (playerPos.x + (camWidth/2) > mapPosition.x + (mapWidth/2))
        {
            newPos.x = playerPos.x - playerPos.x - (camWidth / 2) + mapPosition.x + (mapWidth / 2); 
        } else if (playerPos.x - (camWidth/2) < mapPosition.x - (mapWidth/2))
        {
            newPos.x = playerPos.x + mapPosition.x - (mapWidth / 2) - playerPos.x + (camWidth / 2);
        }
        if (playerPos.y + (camHeight/2) > mapPosition.y + (mapHeight/2))
        {
            newPos.y = playerPos.y - playerPos.y - (camHeight / 2) + mapPosition.y + (mapHeight / 2);
        } else if (playerPos.y - (camHeight / 2) < mapPosition.y - (mapHeight / 2))
        {
            newPos.y = playerPos.y + mapPosition.y - (mapHeight / 2) - playerPos.y + (camHeight / 2);
        }
        newPos.z = cc_camera.transform.position.z;
        cc_camera.transform.position = newPos;
    }
    #endregion

    #region Collision Methods
    private void OnTriggerEnter2D(Collider2D collider)
    {
        GameObject other = collider.gameObject;
        if (other.CompareTag("Door"))
        {
            onDoor = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collider)
    {
        GameObject other = collider.gameObject;
        if (other.CompareTag("Door"))
        {
            onDoor = false;
        }
    }
    #endregion
}
