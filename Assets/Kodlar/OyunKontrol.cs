using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OyunKontrol : MonoBehaviour
{
    public GameObject Astreoid;
    public Vector3 randomPos;

    public Text scoreText;
    public Text gameoverText;
    public Text gameoverText2;

    bool oyunbittimi = false;
    bool yenidenbaslat = false;
    int score;
    void Start()
    {
        score = 0;
        scoreText.text = score.ToString();
        StartCoroutine(olustur());
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R) && yenidenbaslat)
        {
            SceneManager.LoadScene("Level 1");
        }
    }
    IEnumerator olustur()
    {
        yield return new WaitForSeconds(2); //oyun başladıktan iki saniye sonra oluşturur.
        while(true) //sonsuz döngü
        {
            for (int i = 0; i < 10; i++)
            {
                Vector3 vec = new Vector3(Random.Range(-randomPos.x, randomPos.x), 0, randomPos.z);
                Instantiate(Astreoid, vec, Quaternion.identity);
                yield return new WaitForSeconds(2); //Bir saniye arayla döngü devam eder.
            }
            if (oyunbittimi)
            {
                break;
            }
            yield return new WaitForSeconds(3);
           
        }
       


    }
    public void ScoreArttir(int gelenScore)
    {
        score += gelenScore;
        scoreText.text = score.ToString();
        Debug.Log(score);
    }

    public void GameOver()
    {

       
        gameoverText.text = "OYUN BİTTİ";
        Destroy(gameObject, 1);
        yenidenbaslat = true;
        gameoverText2.text = "Yeniden Başlatmak İçin R ye Bas";
        oyunbittimi = true;
    }
}
