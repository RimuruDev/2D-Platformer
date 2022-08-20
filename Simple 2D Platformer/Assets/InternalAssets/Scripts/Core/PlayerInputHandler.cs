using UnityEngine;

namespace RimuruDev.Core
{
    public sealed class PlayerInputHandler
    {
        public void MotionX(Rigidbody2D rigidbody2D, float horizontaiInput, float motionSpeed)
        {
            rigidbody2D.velocity = new(horizontaiInput * motionSpeed, rigidbody2D.velocity.y);
        }

        public void Jump(Rigidbody2D rigidbody2D, float jumpForce, bool state)
        {
            if (Input.GetButtonDown("Jump") &&state)
                rigidbody2D.velocity = new(rigidbody2D.velocity.x, jumpForce);
        }

        public float GetHorizontalInput() => Input.GetAxisRaw("Horizontal");

        public float GetVerticalInput() => Input.GetAxisRaw("Vertical");
    }
}