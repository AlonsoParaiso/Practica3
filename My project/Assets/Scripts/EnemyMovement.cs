using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public Transform pingu;
    public float speedEnemy;
    private SpriteRenderer _rend;
    public int value = 1;
    private int valueTotal;
    public AudioClip audioClip;
    private Vector2 pos;
    // Start is called before the first frame update
    void Start()
    {
        _rend = GetComponent<SpriteRenderer>();
        pos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (pingu != null)
        {
            transform.position = Vector2.MoveTowards(transform.position, new Vector2(pingu.position.x, transform.position.y), speedEnemy * Time.deltaTime);

            if (pos.x>transform.position.x)
            {
                _rend.flipX = false;
                pos = transform.position;
            }
            else
            {
                _rend.flipX = true;
                pos = transform.position;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<PlayerMovement>())
        {
            AudioManager.instance.PlayAudio(audioClip, "deahtEnemySound", false);
            valueTotal = GameManager.instance.GetPoints();
            valueTotal = value + valueTotal;
            GameManager.instance.SetPoints(valueTotal);
            Destroy(gameObject);
        }
    }
}
