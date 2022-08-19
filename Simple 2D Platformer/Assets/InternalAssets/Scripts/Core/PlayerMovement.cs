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

            playerInputHandler.Jump(dataContainer.playerRigidbody2D, dataContainer.jumpForce);

            PlayerFlipController();

            UpdateAnimations();
        }

        private void UpdateAnimations()
        {
            float directionX = playerInputHandler.GetHorizontalInput();

            if (directionX > 0f || directionX < 0f)
                animationController.Running("running", dataContainer.playerAnimator, true);
            else
                animationController.Running("running", dataContainer.playerAnimator, false);
        }

        private void PlayerFlipController()
        {
            if (playerInputHandler.GetHorizontalInput() < 0f) animationController.FlipX(dataContainer.playerSprite, true);

            if (playerInputHandler.GetHorizontalInput() > 0f) animationController.FlipX(dataContainer.playerSprite, false);
        }
    }
}