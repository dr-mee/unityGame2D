using UnityEngine;

public class Shooter : MonoBehaviour
{
    public GameObject projectile;
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            var projectileObject = Instantiate(projectile, transform.position + new Vector3(2, 0, 0), projectile.transform.rotation);

        }
    }
}
