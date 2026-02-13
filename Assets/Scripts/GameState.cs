using UnityEngine;

public class GameState : MonoBehaviour
{

    public int hitCount = 0;
    public const string ENEMY_TAG = "Enemy";

    void OnTriggerEnter(Collider other)
    {
        //if (other.gameObject.tag  == "Enemy")
        //{

        //    hitCount++;
        //}
        if (other.gameObject.CompareTag("Enemy") )
        {

            hitCount++;
        }

        if (hitCount >= 5000000000000)
        {
            Debug.Log("Game OVER");
            Time.timeScale = 0f;
            
        }

    }
}
