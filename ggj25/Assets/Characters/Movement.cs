using UnityEngine;

namespace Characters
{
    public class Movement : MonoBehaviour
    {
        [SerializeField]
        public float speed = 15;

        public void Update()
        {
            var h = Input.GetAxis("Horizontal");
            var v = Input.GetAxis("Vertical");

            var tempVect = new Vector3(h, v, 0);
            tempVect = tempVect.normalized * (speed * Time.deltaTime);

            transform.position += tempVect;
        }
    }
}