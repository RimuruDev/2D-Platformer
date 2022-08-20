using UnityEngine;

namespace Assets.InternalAssets.Scripts.Core
{
    public sealed class UIController : MonoBehaviour
    {
        private GameDataContainer dataContainer;

        private void Awake()
        {
            if (dataContainer == null)
                dataContainer = GameObject.FindObjectOfType<GameDataContainer>();
        }

        private void Update()
        {
            dataContainer.scoreText.text = $"Cherrys: {dataContainer.score}";
        }
    }
}