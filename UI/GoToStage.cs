using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToStage : MonoBehaviour
{
    public int number;
    public void GetStage(int number)
    {
        SceneManager.LoadScene(number);
    }
}
