using UnityEngine;

public class DeathTrigger : MonoBehaviour
{
    public GameObject usePrompt;
    public DeathManager deathManager;

    private bool playerInside;

    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player")) return;

        playerInside = true;
        if (usePrompt != null)
            usePrompt.SetActive(true);
    }

    private void OnTriggerExit(Collider other)
    {
        if (!other.CompareTag("Player")) return;

        playerInside = false;
        if (usePrompt != null)
            usePrompt.SetActive(false);
    }

    private void Update()
    {
        if (playerInside && Input.GetKeyDown(KeyCode.E))
        {
            deathManager.DeathScreen();
            this.enabled=false;
        }
    }
}
