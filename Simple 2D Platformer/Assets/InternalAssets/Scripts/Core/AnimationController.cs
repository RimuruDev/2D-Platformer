using UnityEngine;

namespace RimuruDev.Core
{
    public sealed class AnimationController
    {
        public void Running(string name, Animator animator, bool state) =>
            animator.SetBool(name, state);

        public void FlipX(SpriteRenderer sprite, bool flipX) => sprite.flipX = flipX;

        public void FlipY(SpriteRenderer sprite, bool flipY) => sprite.flipY = flipY;
    }
}