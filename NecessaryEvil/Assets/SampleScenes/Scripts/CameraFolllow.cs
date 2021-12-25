using UnityEngine;
using System.Collections;

public class CameraFolllow : MonoBehaviour
{
    public Transform target;
    public Transform leftBounds;
    public Transform rightBounds;
    public float smoothDampTime = 0.15f;
    private Vector3 smoothDamoVelocity = Vector3.zero;
    private float camWidth, camHeight, levelMinx, levelMaxX;

    

    // Start is called before the first frame update
    void Start()
    {
        camHeight = Camera.main.orthographicSize * 2;
        camWidth = camHeight * Camera.main.aspect;
        float leftBoundsWidth = leftBounds.GetComponentInChildren<SpriteRenderer>().bounds.size.x / 2;
        float rightBoundsWidth = rightBounds.GetComponentInChildren<SpriteRenderer>().bounds.size.x / 2;
        levelMinx = leftBounds.position.x + leftBoundsWidth + (camWidth / 2);
        levelMaxX = rightBounds.position.x - leftBoundsWidth - (camWidth / 2);


    }

    // Update is called once per frame
    void Update()
    {
        if(target)
        {
            float targetX = Mathf.Max(levelMinx, Mathf.Min(levelMaxX, target.position.x));
            float x = Mathf.SmoothDamp(transform.position.x, targetX, ref smoothDamoVelocity.x, smoothDampTime);
            transform.position = new Vector3(x, transform.position.y, transform.position.z);
        }
        
    }
}
