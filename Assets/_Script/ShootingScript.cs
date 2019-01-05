using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShootingScript : MonoBehaviour
{
    public GameObject explosion;
    public GameObject gameCamera;
    public GameObject evidence;
    public Text evidenceTitleText;
    public Text evidenceText;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Shoot()
    {
        RaycastHit hit;
        if (Physics.Raycast(gameCamera.transform.position, gameCamera.transform.forward, out hit))
        {
            
            switch (hit.transform.name)
            {
                case "bottle":
                    evidenceTitleText.text = "可口可乐";
                    evidenceText.text = "一瓶可口可乐，和案件似乎没有什么关系";
                    //destory the evidence
                    Destroy(hit.transform.gameObject);
                    //show exposion animation
                    GameObject go = Instantiate(explosion, hit.point, Quaternion.LookRotation(hit.normal));

                    evidence.SetActive(true);
                    break;
                case "USB":
                    evidenceTitleText.text = "U盘";
                    evidenceText.text = "太平间里面发现一个U盘";
                    //destory the evidence
                    Destroy(hit.transform.gameObject);
                    //show exposion animation
                    GameObject go1 = Instantiate(explosion, hit.point, Quaternion.LookRotation(hit.normal));
                    evidence.SetActive(true);
                    break;
                case "NPC1":
                    evidenceTitleText.text = "路人甲";
                    evidenceText.text = "路人甲：每晚闹鬼的时候，总是不见撒保安的身影。";
                    //destory the evidence
                    Destroy(hit.transform.gameObject);
                    //show exposion animation
                    GameObject go2 = Instantiate(explosion, hit.point, Quaternion.LookRotation(hit.normal));
                    evidence.SetActive(true);
                    break;
                case "NPC2":
                    evidenceTitleText.text = "路人乙";
                    evidenceText.text = "路人乙：苏护士在姐姐死后，郑院长有特地去看她。";
                    //destory the evidence
                    Destroy(hit.transform.gameObject);
                    //show exposion animation
                    GameObject go3 = Instantiate(explosion, hit.point, Quaternion.LookRotation(hit.normal));
                    evidence.SetActive(true);
                    break;
                case "Npc3":
                    evidenceTitleText.text = "路人丙";
                    evidenceText.text = "路人丙：医院所有维修单上，签名的都是撒保安。";
                    //destory the evidence
                    Destroy(hit.transform.gameObject);
                    //show exposion animation
                    GameObject go4 = Instantiate(explosion, hit.point, Quaternion.LookRotation(hit.normal));
                    evidence.SetActive(true);
                    break;
                case "potion":
                    evidenceTitleText.text = "电梯里的一针就死";
                    evidenceText.text = "电梯内有一瓶“一针就死”毒药";
                    //destory the evidence
                    Destroy(hit.transform.gameObject);
                    //show exposion animation
                    GameObject go5 = Instantiate(explosion, hit.point, Quaternion.LookRotation(hit.normal));
                    evidence.SetActive(true);
                    break;
                case "HBG":
                    evidenceTitleText.text = "韩八卦的口袋";
                    evidenceText.text = "八卦记者随身袋子里发现手套、针筒";
                    //destory the evidence
                    Destroy(hit.transform.gameObject);
                    //show exposion animation
                    GameObject go6= Instantiate(explosion, hit.point, Quaternion.LookRotation(hit.normal));
                    evidence.SetActive(true);
                    break;
                case "handrail":
                    evidenceTitleText.text = "栏杆失修";
                    evidenceText.text = "八卦记者的笔记本中夹了一张纸条，上面写着栏杆失修，不要靠近。";
                    //destory the evidence
                    Destroy(hit.transform.gameObject);
                    //show exposion animation
                    GameObject g7 = Instantiate(explosion, hit.point, Quaternion.LookRotation(hit.normal));
                    evidence.SetActive(true);
                    break;
                case "syringe2":
                    evidenceTitleText.text = "凌办公室的一针就死";
                    evidenceText.text = "凌主任办公室内发现一支带有“一针就死”毒药的针管。";
                    //destory the evidence
                    Destroy(hit.transform.gameObject);
                    //show exposion animation
                    GameObject go8 = Instantiate(explosion, hit.point, Quaternion.LookRotation(hit.normal));
                    evidence.SetActive(true);
                    break;
                case "camera":
                    evidenceTitleText.text = "摄像头";
                    evidenceText.text = "通往太平间的电梯监控录像，坏了一段时间没维修，什么都没拍下。";
                    //destory the evidence
                    Destroy(hit.transform.gameObject);
                    //show exposion animation
                    GameObject go9 = Instantiate(explosion, hit.point, Quaternion.LookRotation(hit.normal));
                    evidence.SetActive(true);
                    break;
                default:
                    break;
            }

        }
    }

    //void ShowEvidence(RaycastHit dispear)
    //{
    //    //destory the evidence
    //    Destroy(dispear.transform.gameObject);
    //    //show exposion animation
    //    GameObject go = Instantiate(explosion, dispear.point, Quaternion.LookRotation(dispear.normal));
    //    evidence.SetActive(true);
    //}
}
