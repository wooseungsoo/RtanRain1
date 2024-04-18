using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rain : MonoBehaviour
{
    float size = 1.0f;
    int score = 1;

    SpriteRenderer renderer;
    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<SpriteRenderer>();
        float x = Random.Range(-2.4f, 2.4f);
            float y = Random.Range(3.0f, 5.0f);

        transform.position = new Vector3(x, y, 0);


        int type = Random.Range(1, 4);

        if (type == 1)
        {
            size = 0.8f;
            score = -5;
           renderer.color = new Color(255 / 255f, 100 / 255f, 1f, 1f);
        }
        else if(type==2)
        {
            size = 0.8f;
            score = -5;
            renderer.color = new Color(255 / 255f, 100 / 255f, 1f, 1f);
        }
    
        else if(type==3)
        {
            size = 0.8f;
            score = -5;
            renderer.color = new Color(255 / 255f, 100 / 255f, 1f, 1f);

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Ground"))
        {
            Destroy(this.gameObject);
        }

        if(collision.gameObject.CompareTag("Player"))
        {
            GameManager.Instance.AddScore(score);
            Destroy(this.gameObject);
        }
    }
}
