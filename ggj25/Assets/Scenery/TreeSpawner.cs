using UnityEngine;

public class TreeSpawner : MonoBehaviour
{
    public GameObject tree;
    public float rate = 4;
    private float _timer = 4;

    // Start is called before the first frame update
    void Start()
    {
        SpawnTree();
    }

    // Update is called once per frame
    void Update()
    {
        SpawnTree();
    }

    private void SpawnTree()
    {
        if (_timer < rate)
        {
            _timer += Time.deltaTime;
        }
        else
        {
            Instantiate(tree, transform.position, transform.rotation);
            _timer = 0;
        }
    }
}