using UnityEngine;

namespace RimuruDev.Core
{
    public sealed class ItemController : MonoBehaviour
    {
        private GameDataContainer dataContainer;

        private void Awake()
        {
            if (dataContainer == null)
                dataContainer = GameObject.FindObjectOfType<GameDataContainer>();
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (!collision.gameObject.CompareTag(Tag.Cherry)) return;

            Destroy(collision.gameObject);

            dataContainer.score++;
        }
    }
}