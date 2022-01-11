using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GoToUrl : MonoBehaviour
{
    public Text Word;
    public void OpenURL()
    {
        Application.OpenURL($"https://www.google.com/search?q={Word.text}");
        /*Application.OpenURL($"https://search.naver.com/search.naver?where=nexearch&sm=top_hty&fbm=1&ie=utf8&query={Word.text}");*/
    }
}
