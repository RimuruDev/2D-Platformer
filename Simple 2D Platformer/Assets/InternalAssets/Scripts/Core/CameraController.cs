using UnityEngine;

namespace RimuruDev.Core
{
    public sealed class CameraController : MonoBehaviour
    {
        public GameDataContainer dataContainer;

        private void Awake()
        {
            if (dataContainer == null)
                dataContainer = GameObject.FindObjectOfType<GameDataContainer>();
        }

        private void Update() => CameraMotion();

        private void CameraMotion() =>
            transform.position = new Vector3(dataContainer.player.transform.position.x, dataContainer.player.transform.position.y, transform.position.z);
    }
}