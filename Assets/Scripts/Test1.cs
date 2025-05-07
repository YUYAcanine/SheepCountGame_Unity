using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//追加する！
using UnityEngine.UI;
using UnityEngine.SceneManagement;

 
public class Test : MonoBehaviour 
{
 
  //オブジェクトと結びつける
  public InputField inputField;
  int inputNumber;
  void Start () 
  {
    //Componentを扱えるようにする
    inputField = inputField.GetComponent<InputField> ();
  }
 
  public void InputText()
  {
    int.TryParse(inputField.text, out inputNumber);
    if (inputNumber == Sheep2Generator.SheepCount)
    {
      SceneManager.LoadScene("ClearScene");
    }
    else
    {
      SceneManager.LoadScene("NotClearScene");
    }
 
  }
}
