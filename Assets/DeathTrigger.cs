using UnityEngine;
public class DeathTrigger : MonoBehaviour
{
    private bool death_active=false;
    public GameObject use;
    private void OnTriggerEnter(Collider other)
    {
        use.SetActive(true);
    }
    private void OnTriggerExit(Collider other)
    {
        use.SetActive(false);
        if (other.CompareTag("Player"))
        {
            death_active=false;
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            death_active=true;
        }
    }
    void Update()
    {
        if (death_active==true && Input.GetKeyDown(KeyCode.E))
        {
            DeathManager.Instance.TriggerDeath();
        }
    }
}