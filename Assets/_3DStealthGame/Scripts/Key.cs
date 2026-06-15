using UnityEngine;

public class Key : MonoBehaviour
{
    public string KeyName;

    private void OnTriggerEnter(Collider other)
    {
        PlayerController player = other.gameObject.GetComponent<PlayerController>();
        if (player == null) return;

        player.AddKey(KeyName);
        Destroy(gameObject);
    }
}
