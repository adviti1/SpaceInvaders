using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace goblegoble
{
    public class PlayerControl : MonoBehaviour
    {
        public float moveSpeed = 5;
        private float hInput;
        private float vInput;

        void Update()
        {
            hInput = Input.GetAxisRaw("Horizontal");
            vInput = Input.GetAxisRaw("Vertical");

            transform.Translate(Vector2.right * hInput * moveSpeed * Time.deltaTime);
            transform.Translate(Vector2.up * vInput * moveSpeed * Time.deltaTime);
        }
    }
}

