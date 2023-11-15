using UnityEngine;

public class Target : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PlayerHoop"))
        {
            // Player scores a point
            GameManager.Instance.PlayerScored();
        }
        else if (other.CompareTag("AIHoop"))
        {
            // AI scores a point
            GameManager.Instance.AIScored();
        }
    }
}
