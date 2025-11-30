using UnityEngine;

public class finishLine : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
       if (collision.tag == "Player")
        { }
    }
}