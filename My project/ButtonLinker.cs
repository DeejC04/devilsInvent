using UnityEngine;
public class ButtonLinker : MonoBehavior {
    public string Url;

    void Open(){
        Application.OpenURL(Url);
    }
}