using UnityEngine;
//https://docs.unity3d.com/ScriptReference/Collider2D.OnTriggerExit2D.html
public class DetectLight : MonoBehaviour
{
    bool characterInQuicksand; 

    void OnTriggerExit2D( Collider2D other)
    {
        characterInQuicksand = false;
        if (other.CompareTag("Player"))
        {
            other.enabled = false;
        }
    }
}
