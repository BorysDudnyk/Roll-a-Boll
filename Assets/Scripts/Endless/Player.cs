using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    [SerializeField] private GameObject losePanel;
    [SerializeField] private bool gameOver;
    public int coins;
    //public Text TextCoins;

    private void Start()
    {
        losePanel.SetActive(false);
        Time.timeScale = 1;
    }

    private void Update()
    {
        if(!gameOver){
            if (Input.GetKeyDown(KeyCode.Mouse1))
            {
                MouseLeft();
            }
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                MouseRight();
            }
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
            MouseLeft();
            }
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
            MouseRight();
            }
        }
    }

    private void MouseLeft()
    {
        if (transform.position.z != 3)
        {
            transform.position = new Vector3(0, 0, transform.position.z + 3);
        }
    }
    private void MouseRight()
    {
        if (transform.position.z != -3)
        {
            transform.position = new Vector3(0, 0, transform.position.z - 3);
        }
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Coin")
        {
            coins++;
            other.gameObject.SetActive(false);
            //TextCoins.text = coins.ToString();
        }
    }

    private void OnCollisionEnter(Collision enemy)
    {
            if (enemy.collider.GetComponent<MoveEnemy>())
            {
                Time.timeScale = 0;
                losePanel.SetActive(true);
                gameOver = true;
            }
    }

    
}
