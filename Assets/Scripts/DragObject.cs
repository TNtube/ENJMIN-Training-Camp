using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragObject : MonoBehaviour
{
    private Vector3 mOffset;
    public bool clicked;
    private float mZCoord;
    public bool dropped;

    void OnMouseDown()
    {
        if (dropped == false)
        {
            mZCoord = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
            mOffset = gameObject.transform.position - GetMouseWorldPos();
        }


    }

    private Vector3 GetMouseWorldPos()
    {
        Vector3 mousePoint = Input.mousePosition;

        mousePoint.z = mZCoord;

        return Camera.main.ScreenToWorldPoint(mousePoint);
    }

    void OnMouseDrag()
    {
        if (dropped == false)
        {
            transform.position = new Vector3(GetMouseWorldPos().x + mOffset.x, transform.position.y, GetMouseWorldPos().z + mOffset.z);
        }


    }
    void OnMouseUp()
    {
        dropped = true;

        if (clicked == false)
        {
            Rigidbody rb = gameObject.GetComponent<Rigidbody>();
            rb.isKinematic = false;
            rb.useGravity = true;
            gameObject.GetComponent<MeshCollider>().isTrigger = false;

            clicked = true;
            

            GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>().OnPlaced();

        }
    }

    
}

