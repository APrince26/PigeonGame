using UnityEngine;

public class FollowPlayerScript : MonoBehaviour
{
    public Transform target; 
    public float speed = 5f;

    void Update()
    {
        if (target == null) return;

        Vector2 direction = (target.position - transform.position).normalized;
        transform.position += (Vector3)(direction * speed * Time.deltaTime);
    }
}
