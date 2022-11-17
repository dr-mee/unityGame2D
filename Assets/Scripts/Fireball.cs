using UnityEngine;

public class Fireball : MonoBehaviour
{
    public Vector2 startingVelocity;

    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = startingVelocity;
        Destroy(gameObject, 10);
    }

    private void Update()
    {
        if (transform.position.x >= 9)
            Destroy(gameObject);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        var enemy = collision.collider.GetComponent<Enemy>();
        enemy?.Die();
        Destroy(gameObject);

    }
}
