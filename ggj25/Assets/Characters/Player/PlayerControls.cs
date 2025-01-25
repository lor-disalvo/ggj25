using UnityEngine;

namespace Characters
{
    public class PlayerControls : MonoBehaviour
    {
        [SerializeField] public float speed = 15;

        public SpriteRenderer sprite;

        public void Update()
        {
            Movement();
        }

        private void Movement()
        {
            var h = Input.GetAxis("Horizontal");
            var v = Input.GetAxis("Vertical");
            if (h != 0) sprite.flipX = h < 0;

            var tempVect = new Vector3(h, v, 0);
            tempVect = tempVect.normalized * (speed * Time.deltaTime);

            transform.position += tempVect;
        }

        private void Attack()
        {
            
        }
    }
}