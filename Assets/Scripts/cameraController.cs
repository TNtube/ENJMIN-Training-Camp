using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


    public class cameraController : MonoBehaviour
    {
        public Vector3 offSet;
        public Camera Cam;
        private Vector3 center = new Vector3(0, 0, 0);

        // Update is called once per frame
        private void Start()
        {
            Cam.transform.position += offSet;
        }

        void Update()
        {
            if (Input.GetMouseButton(1))
            {
                float rotate = Input.GetAxis("Mouse X") * 2;
                Cam.transform.RotateAround(center, new Vector3(0, 1, 0), rotate);
            }
        }
    }
