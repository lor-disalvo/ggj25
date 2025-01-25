using UnityEngine;

public class jump : MonoBehaviour
{
    public Rigidbody2D body;
    public float jumpDistance = 12;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)){
            body.velocity = Vector2.up * jumpDistance;
        }
    }
}
