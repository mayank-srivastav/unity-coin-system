using UnityEngine;
using UnityEngine.UI;

public class Coindisplay : MonoBehaviour
{
    private int coinss = 0;
    public Text coindisplay;

    public void addcoin()
    {
        coinss += 1;
        coindisplay.text = coinss.ToString();
    }
}
