using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class GameDataContainer : MonoBehaviour
{
    [Header("Player Conponents and settings")]
    public Transform player;
    public SpriteRenderer playerSprite;
    public Rigidbody2D playerRigidbody2D;
    public Animator playerAnimator;
    [Space]
    public float jumpForce;
    public float motionSpeed;
}
