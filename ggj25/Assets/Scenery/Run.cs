using UnityEngine;

namespace Scenary
{
    public class Run : MonoBehaviour
    {
        public float movingSpeed = 4F;
        private const float DeadZone = -15;

        void Update()
        {
            transform.position += Vector3.left * (movingSpeed * Time.deltaTime);
            if (transform.position.x < DeadZone) Destroy(gameObject);
        }
    }
}