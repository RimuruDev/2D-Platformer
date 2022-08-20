using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace RimuruDev.Core
{
    public sealed class PlayerLife : MonoBehaviour
    {
        private GameDataContainer dataContainer;

        private void Awake()
        {
            if (dataContainer == null)
                dataContainer = GameObject.FindObjectOfType<GameDataContainer>();
        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (!collision.gameObject.CompareTag(Tag.Traps)) return;

            Die();
        }

        private void Die()
        {
            dataContainer.playerRigidbody2D.bodyType = RigidbodyType2D.Static;
            dataContainer.playerAnimator.SetTrigger("Death");
        }

        private void RestartLevel()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}