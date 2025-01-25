using UnityEngine;

namespace Characters
{
    public class Movement : MonoBehaviour
    {
        public Rigidbody2D body;
        public float speed = 70;

        public void Update()
        {
            var h = Input.GetAxis("Horizontal");
            var v = Input.GetAxis("Vertical");

            var tempVect = new Vector3(h, v, 0);
            tempVect = tempVect.normalized * (speed * Time.deltaTime);
            body.MovePosition(body.transform.position + tempVect);
        }
    }
}