using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject Arrow;
    public GameObject Hp;
    public int hp = 10;
    public Text Score;
    public int score = 0;
    void Start()
    {
        InvokeRepeating("ArrowShot", 0, 1.0f);
        Score.text = "分數:" + score ;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void ArrowShot()
    {
        Instantiate(Arrow, new Vector3(Random.Range(-3, 3), 10, 0), Quaternion.identity);
    }
    public void DecreaseHp()
    {
        Hp.GetComponent<Image>().fillAmount -= 0.1f;
        hp -= 1;
        if (hp <= 0)
        {
            SceneManager.LoadScene("GameOver");
        }
    }
    public void addScore()
    {
        score += 10;
        Score.text = "分數:" + score;
    }
}
