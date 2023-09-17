using UnityEngine;
public class URLLinker : MonoBehaviour {
    public string Url;

    public void Open()
    {
        Application.OpenURL(Url);
    }
}