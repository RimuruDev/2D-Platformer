using UnityEngine;

namespace RimuruDev.Core
{
    public sealed class PlayerMovement : MonoBehaviour
    {
        public GameDataContainer dataContainer;
        private AnimationController animationController;
        private PlayerInputHandler playerInputHandler;

        private void Awake()
        {
            if (dataContainer == null)
                dataContainer = GameObject.FindObjectOfType<GameDataContainer>();

            playerInputHandler = new PlayerInputHandler();
            animationController = new AnimationController();
        }

        private void Update()
        {
            playerInputHandler.MotionX(dataContainer.playerRigidbody2D, playerInputHandler.GetHorizontalInput(), dataContainer.motionSpeed);

            playerInputHandler.Jump(dataContainer.playerRigidbody2D, dataContainer.jumpForce, IsGrounded());

            PlayerFlipController();

            UpdateAnimations();
        }

        private void UpdateAnimations()
        {
            AnimationStates animationStates;

            float directionX = playerInputHandler.GetHorizontalInput();

            if (directionX > 0f || directionX < 0f)
                animationStates = AnimationStates.Running;
            else
                animationStates = AnimationStates.Idle;

            if (dataContainer.playerRigidbody2D.velocity.y > 0.1f)
                animationStates = AnimationStates.Jumping;
            else if (dataContainer.playerRigidbody2D.velocity.y < -0.1f)
                animationStates = AnimationStates.Falling;

            dataContainer.playerAnimator.SetInteger(Tag.AnimationState, (int)animationStates);
        }

        private bool IsGrounded() =>
            Physics2D.BoxCast(dataContainer.playerBoxCollider2D.bounds.center, dataContainer.playerBoxCollider2D.bounds.size, 0f, Vector2.down, 0.1f, dataContainer.jumpableGrounded);

        private void PlayerFlipController()
        {
            if (playerInputHandler.GetHorizontalInput() < 0f) animationController.FlipX(dataContainer.playerSprite, true);

            if (playerInputHandler.GetHorizontalInput() > 0f) animationController.FlipX(dataContainer.playerSprite, false);
        }
    }
}