using UnityEngine;

public class MoveUpAndDown : MonoBehaviour
{
    public float UpDownSpeed = 1;

    void Update()
    {
        transform.position += Vector3.up * Mathf.Sin(Time.time) * Time.deltaTime * UpDownSpeed;
        
    }
}
