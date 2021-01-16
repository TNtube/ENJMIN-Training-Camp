using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragObject : MonoBehaviour
{
    private Vector3 mOffset;
    public bool clicked;
    public int value;
    public Rigidbody gameObjectsRigidBody;

    private float mZCoord;
    public bool dropped;

    // Start is called before the first frame update
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

    // Update is called once per frame
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
            gameObjectsRigidBody = gameObject.AddComponent<Rigidbody>();

            clicked = true;
            switch (value)
            {
                case 0:
                    gameObjectsRigidBody.mass = 1;
                    break;

                case 1:
                    gameObjectsRigidBody.mass = 3;
                    break;

                case 2:
                    gameObjectsRigidBody.mass = 7;
                    break;
            }

            GameObject.Find("Main Camera").GetComponent<GameController>().OnPlaced();

        }
    }
}

