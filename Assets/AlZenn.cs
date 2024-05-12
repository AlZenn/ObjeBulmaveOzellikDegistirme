using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class AlZenn : MonoBehaviour
{
    
    // Start is called before the first frame update
    private GameObject[] obje = new GameObject[10];


    private Text _text;
    private Button _button;
    private InputField _inputField;
    private GameObject _panel;
    private Toggle _toggle;

    private void Awake()
    {
        _panel = GameObject.Find("PanelO");
    }

    void Start()
    {
        _text = GameObject.Find("TextO").GetComponent<Text>();
        _button = GameObject.Find("ButtonO").GetComponent<Button>();
        _inputField = GameObject.Find("InputFieldO").GetComponent<InputField>();
        
        _toggle = GameObject.Find("ToggleO").GetComponent<Toggle>();

        _text.text = "alzenn";
        _toggle.isOn = false;
        _panel.SetActive(false);
        _inputField.interactable = false;
        _button.interactable = false;
        
        for (int i = 0; i < 10; i++)
        {
            obje[i] = new GameObject("obj" +i);
            
            if (i <5)
            {
                obje[i].tag = "Player";
            }

            switch (i)
            {
              case 0:
                  
                  AudioSource AS = GameObject.Find("obj"+i).AddComponent<AudioSource>();
                  AS.mute = true;
                  break;
              case 1:
                  Rigidbody RB =  GameObject.Find("obj"+i).AddComponent<Rigidbody>();
                  RB.mass = 1f;
                  break;
                  case 2:
                     BoxCollider BC = GameObject.Find("obj"+i).AddComponent<BoxCollider>();
                     BC.enabled = false;
                     break;
                  case 3:
                      zenn alZenn = GameObject.Find("obj"+i).AddComponent<zenn>();
                      alZenn.toplam = 1;
                      break;
                case 4:
                          End END = GameObject.Find("obj"+i).AddComponent<End>();
                          END.EndSC = 1;
                          break;
                case 5:
                    CapsuleCollider CC = GameObject.Find("obj"+i).AddComponent<CapsuleCollider>();
                    CC.isTrigger = false;
                    break;
                case 6:
                    Rigidbody RB2 = GameObject.Find("obj"+i).AddComponent<Rigidbody>();
                    RB2.drag = 1f;
                    break;
                case 7:
                    Rigidbody RB3 = GameObject.Find("obj"+i).AddComponent<Rigidbody>();
                    RB3.position = Vector3.up;
                    break;
                case 8:
                    SphereCollider SC = GameObject.Find("obj"+i).AddComponent<SphereCollider>();
                    SC.center = Vector3.back;
                    break;
                case 9:
                    Vuu VUU =  GameObject.Find("obj"+i).AddComponent<Vuu>();
                    VUU.VuuSC = 1;
                    break;
              default:
                  break;
            }
            
            
            
            
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
