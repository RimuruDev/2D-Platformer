using RimuruDev.Core;
using UnityEngine;

public sealed class StickyPlatform : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!collision.gameObject.CompareTag(Tag.Player)) return;

        collision.gameObject.transform.SetParent(transform);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (!collision.gameObject.CompareTag(Tag.Player)) return;

        collision.gameObject.transform.SetParent(null);
    }
}