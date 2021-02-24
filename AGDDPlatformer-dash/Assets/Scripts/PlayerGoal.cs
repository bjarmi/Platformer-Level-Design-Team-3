using UnityEngine;

namespace AGDDPlatformer
{
    public class PlayerGoal : MonoBehaviour
    {
        public string playerTag;
        public bool isSatisfied;

        public GameObject satisfactionIndicator;
        public AudioSource source;

        private void Start()
        {
            satisfactionIndicator.SetActive(false);
        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (!other.CompareTag(playerTag)) return;
            isSatisfied = true;
            satisfactionIndicator.SetActive(true);
            source.Play();
        }

        private void OnTriggerExit2D(Collider2D other)
        {
            if (!other.CompareTag(playerTag)) return;
            isSatisfied = false;
            satisfactionIndicator.SetActive(false);
        }
    }
}