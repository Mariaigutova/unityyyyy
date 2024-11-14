using System.Collections; 
using System.Collections.Generic; 
using UnityEngine; 
using UnityEngine.SceneManagement; 
 
 
public class enemysc : MonoBehaviour 
{ 
    public LevelManager levelManager; 
 
    private void OnCollisionEnter2D(Collision2D collision) 
    { 
        if (collision.gameObject.tag == "Player") 
        { 
            SceneManager.LoadScene(0); 
        } 
    } 
    private void OnTriggerEnter2D(Collider2D collision) 
    { 
        if (collision.gameObject.tag == "Player") 
        { 
             
            Destroy(gameObject); 
            levelManager.EnemyKilled(); 
 
        } 
         
    } 
}