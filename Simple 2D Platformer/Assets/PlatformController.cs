using UnityEngine;

namespace RimuruDev.Core
{
    public sealed class PlatformController : MonoBehaviour
    {
        public Transform[] wayPoints;
        public int currentWayPointsIndex = 0;
        public float speed = 2;

        private void Update()
        {
            if (Vector2.Distance(wayPoints[currentWayPointsIndex].position, transform.position) < 0.1f)
            {
                currentWayPointsIndex++;

                if (currentWayPointsIndex >= wayPoints.Length)
                    currentWayPointsIndex = 0;
            }
            transform.position = Vector2.MoveTowards(transform.position, wayPoints[currentWayPointsIndex].position, Time.deltaTime * speed);
        }
    }
}