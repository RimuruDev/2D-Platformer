using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public sealed class GameDataContainer : MonoBehaviour
{
    public static GameDataContainer instance;

    private void Awake()
    {
        instance = this;
    }


    [Header("Player Conponents and settings")]
    public Transform player;
    public BoxCollider2D playerBoxCollider2D;
    public SpriteRenderer playerSprite;
    public Rigidbody2D playerRigidbody2D;
    public Animator playerAnimator;
    [Space]
    public float jumpForce;
    public float motionSpeed;
    public LayerMask jumpableGrounded;

    [Header("UI")]
    public Text scoreText;
    public int score;
    public AudioSource jumpEffect;
}
