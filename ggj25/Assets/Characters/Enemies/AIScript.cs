using System;
using System.Threading;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Characters.Enemies
{
    public class AIScript : MonoBehaviour
    {
        public enum EnemyType
        {
            Small,
            Medium,
            Large,
            Muskrat
        }

        [SerializeField] public EnemyType type;
        private GameObject _player;
        public SpriteRenderer sprite;

        public float step = 1;
        public bool playerSpotted;

        void Start()
        {
            _player = GameObject.FindGameObjectWithTag("Player");
            switch (type)
            {
                case EnemyType.Small:
                    step *= 2;
                    break;
                case EnemyType.Large:
                    step *= .5F;
                    break;
                case EnemyType.Muskrat:
                    step *= 1.5F;
                    break;
                case EnemyType.Medium:
                default:
                    break;
            }
        }

        void Update()
        {
            if (!playerSpotted) CheckForPlayer();
            CheckBehaviour();
        }

        private void CheckForPlayer()
        {
            var pos = transform.position;
            var playerPos = _player.transform.position;
            playerSpotted = Vector3.Distance(pos, playerPos) < 10;
            Debug.Log("Player is spotted: "+ playerSpotted);
        }

        private void CheckBehaviour()
        {
            if (!playerSpotted) RandomMove();
            switch (type)
            {
                case EnemyType.Small:
                    DoSmall();
                    break;
                case EnemyType.Medium:
                    DoMedium();
                    break;
                case EnemyType.Large:
                    DoLarge();
                    break;
                case EnemyType.Muskrat:
                    DoMuskrat();
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            Thread.Sleep((int)(Random.value * 2000));
        }

        private void RandomMove()
        {
            var ver = -1 ^ Random.Range(1, 3);
            var hor = -1 ^ Random.Range(1, 3);
            sprite.flipX = hor < 0;
            var dir = new Vector3(1 * hor, 1 * ver, transform.position.z);
            transform.position += dir * (step * Time.deltaTime);
            Thread.Sleep(2000);
        }

        private void DoMedium()
        {
            if (!playerSpotted) return;

            transform.position += Vector3.Lerp(transform.position, _player.transform.position, 4) * Time.deltaTime;
                //_player.transform.position * (step * Time.deltaTime);
            Attack();
        }

        private void DoLarge()
        {
            throw new System.NotImplementedException();
        }

        private void DoSmall()
        {
            throw new System.NotImplementedException();
        }

        private void DoMuskrat()
        {
            throw new System.NotImplementedException();
        }

        private void Attack()
        {
            Debug.Log("Attack");
        }

        public void OnCollisionEnter(Collision other)
        {
            throw new NotImplementedException();
        }
    }
}