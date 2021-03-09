using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChatShowManager : MonoBehaviour
{   
    public GameObject myChat;
    public GameObject otherChat;
    public GameObject content;
    public People[] people = new People[6] { new People{ }, new People { }, new People { }, new People { }, new People { }, new People { } };
    public Sprite[] img;

    private string[] jinyu = {
        "好耶！",
        "好困噢",
        "我吐了",
        "bug改不完了",
        "好困噢",
        "飘香鸡丁！",
    };

    private string[] feng = {
        "香！",
        "冲！",
        "好家伙哈哈哈哈！",
        "不愧是你！",
        "真香！",
        "啊这",
        "卖",
        "困",
        "走去剧本杀",
        "走去唱歌",
        "走去吃拉面",
        "MDD！",
        "乡村！",
        "大米先生！",
        "宇神，惨",
        "好耶"
    };

    private string[] hubo = {
        "好家伙",
        "始祖垃圾，别抽了",
        "野蛮时代真好玩",
        "痛苦",
        "慕了",
        "好耶"
    };

    private string[] songao = {
        "我的腰好痛",
        "哈哈哈",
        "我们要去聚餐",
        "呜呜我要去排练",
        "我被公开处刑了",
        "剧本杀我肯定不是凶手",
        "孙总大气",
        "好耶"
    };

    private string[] pengpeng = {
        "哇我为什么这么早回去",
        "想玩",
        "风神，我能抱你大腿吗",
        "哇",
        "这就是风神吗",
        "冲吗",
        "卖了",
        "好耶",
        "冲",
        "困",
    };

    private string[] yushen = {
        "bug改不完了",
        "我又四十多个bug",
        "啊！床！你是如此的亲切温暖！",
        "我还有十多个bug",
        "老王找我了",
        "U1S1",
        "通宵把脑子通傻了",
        "可恶",
        "我也想哇",
        "留时间改bug",
        "明天要提测bug改不完了",
    };

    private string[] sunzong = {
        "你真的很不错",
        "太强了",
        "一天改了20个bug",
        "牛逼啊！",
        "我吃火锅你吃火锅底料",
        "我能不能中个奖",
        "我能中ps5吗",
        "鬼谷八荒还挺好玩",
        "戴森球太好玩了！",
        "宇神帮我看看我的bug",
        "宇神牛逼",
        "宇神起床了吗",
        "回家过年了",
        "宇神太努力了",
        "宇神太拼了",
        "刚刚睡醒",
    };

    void Awake()
    {
        people[0].img = img[0];
        people[0].name = "Zack 韩凛风";
        people[1].img = img[1];
        people[1].name = "Melody 胡博";
        people[2].img = img[2];
        people[2].name = "Buck 杨宇轩";
        people[3].img = img[3];
        people[3].name = "Peng 彭朋";
        people[4].img = img[4];
        people[4].name = "Sa 宋澳";
        people[5].img = img[5];
        people[5].name = "Revin 孙昊君";
    }


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(KeepShowChat());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator KeepShowChat()
    {
        while (true)
        {
            ShowAChat();    
            yield return new WaitForSeconds(2);
        }

    }

    private void ShowAChat()
    {
        int otherOrMe = Random.Range(0, 7);
        int num = Random.Range(0, 6);
        People now = people[num];
        string theText;

        if (otherOrMe == 0)
        {
            theText = jinyu[Random.Range(0, jinyu.Length)];
            GameObject go = Instantiate(myChat, content.transform);
            go.transform.Find("Image (1)").Find("Text").GetComponent<Text>().text = theText;
        }
        else if (otherOrMe >= 1)
        {
            GameObject go = Instantiate(otherChat, content.transform);
            go.transform.Find("Image").GetComponent<Image>().sprite = now.img;
            go.transform.Find("name").GetComponent<Text>().text = now.name;
            switch (num)
            {
                case 0:
                    theText = feng[Random.Range(0, feng.Length)];
                    go.transform.Find("Image (1)").Find("Text").GetComponent<Text>().text = theText;
                    break;
                case 1:
                    theText = hubo[Random.Range(0, hubo.Length)];
                    go.transform.Find("Image (1)").Find("Text").GetComponent<Text>().text = theText;
                    break;
                case 2:
                    theText = yushen[Random.Range(0, yushen.Length)];
                    go.transform.Find("Image (1)").Find("Text").GetComponent<Text>().text = theText;
                    break;
                case 3:
                    theText = pengpeng[Random.Range(0, pengpeng.Length)];
                    go.transform.Find("Image (1)").Find("Text").GetComponent<Text>().text = theText;
                    break;
                case 4:
                    theText = songao[Random.Range(0, songao.Length)];
                    go.transform.Find("Image (1)").Find("Text").GetComponent<Text>().text = theText;
                    break;
                case 5:
                    theText = sunzong[Random.Range(0, sunzong.Length)];
                    go.transform.Find("Image (1)").Find("Text").GetComponent<Text>().text = theText;
                    break;
                default:
                    print("error!");
                    break;
            }
        }
        else
        {
            print("nononono!");
        }
    }
}
