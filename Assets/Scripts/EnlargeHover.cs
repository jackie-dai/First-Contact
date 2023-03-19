using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnlargeHover : MonoBehaviour
{
    #region Animation variables
    private float animationDuration = 0.20f;
    private float scaleModifier = 1f;
    #endregion
    private Vector2 originalSize;
    private Vector2 targetSize;
    private float scaleFactor = 1.10f;
    #region Sprites
    Transform outline;
    private SpriteRenderer spriteRenderer;
    #endregion
    private KeyCode LeftClick;

    void Awake()
    {
        originalSize = transform.localScale;
        targetSize = new Vector2(scaleFactor, scaleFactor);
        outline = transform.GetChild(0);
        spriteRenderer = GetComponent<SpriteRenderer>();
        LeftClick = KeyCode.Mouse0;
    }

    void OnMouseDown()
    {
        if (transform.tag == "Junkyard")
        {
            SceneManager.LoadScene("Junkyard");
        }
        Debug.Log("SDF");
    }

    void OnMouseEnter()
    {
        Debug.Log("mouse isover");
        transform.localScale = targetSize;
        outline.gameObject.SetActive(true);
        spriteRenderer.enabled = false;

    }


    void OnMouseExit()
    {
        Debug.Log("Scale before: " + transform.localScale);
        transform.localScale = originalSize;
        spriteRenderer.enabled = true;
        outline.gameObject.SetActive(false);
        Debug.Log("Scale after: " + transform.localScale);
    }



    /* SCRAPPED MIGHT REVISIT LATER */
    IEnumerator ScaleAnimation()
    {
        float timeElapsed = 0;
        float startValue = scaleModifier;
        Vector2 original = originalSize;
        float endValue = 1.15f;
        while (timeElapsed < animationDuration)
        {
            scaleModifier = Mathf.Lerp(startValue, endValue, timeElapsed / animationDuration);
            transform.localScale = original * scaleModifier;
            timeElapsed += Time.deltaTime;
            yield return null;
        }
        transform.localScale = original * endValue;
        scaleModifier = endValue;
    }
}
