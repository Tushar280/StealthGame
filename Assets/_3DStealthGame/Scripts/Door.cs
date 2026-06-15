using UnityEngine;

public class Door : MonoBehaviour
{
    public string KeyName;

    private void OnCollisionEnter(Collision collision)
    {
        PlayerController player = collision.gameObject.GetComponent<PlayerController>();
        if (player == null) return;

        if (player.OwnKey(KeyName))
        {
            Destroy(gameObject);
        }
    }
}
