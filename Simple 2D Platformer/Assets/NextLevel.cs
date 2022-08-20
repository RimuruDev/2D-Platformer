using RimuruDev.Core;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    public void NextLevels()
    {
        checked
        {
            int index = SceneManager.GetActiveScene().buildIndex;
            index++;

            SceneManager.LoadScene(index);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!collision.gameObject.CompareTag(Tag.Player)) return;

        NextLevels();
    }
}
