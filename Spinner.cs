using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
namespace StrongCoding
{
    class Spinner
    {


        public Text txt_Reward;

        public Button btn;

        public float[] stopAngles;



        float target;

        public float targetAngle;
        public int index;
        private void Start()
        {


        }

        float zRotation = 0;

        float speed = 1000;

        bool _resultisAssign = false;


        bool canSpin = false;
        public void Spinn()
        {
            index = UnityEngine.Random.Range(0, 23);
            targetAngle = stopAngles[index];
            zRotation = 0;
            speed = 1000;
            _resultisAssign = false;
            canSpin = true;
            btn.interactable = false;
        }
        private void Update()
        {
            if (canSpin)
            {
                float RangeVlue = ((360 * 10)) + targetAngle;
                float midValue = RangeVlue - 360 * 10;

                if (zRotation > midValue)
                {
                    if (speed > 50)
                    {

                        speed -= Time.deltaTime * 150;

                    }
                }


                if (zRotation > RangeVlue)
                {
                    if (!_resultisAssign)
                    {
                        Invoke("AssignResult", 1f);
                        _resultisAssign = true;
                    }
                    return;
                }


                zRotation += Time.deltaTime * speed;
                SpinRotate(zRotation);
            }

        }

        void SpinRotate(float _stopsngle)
        {
            // zRotation = Mathf.LerpAngle(_fromangel, _stopsngle, Time.deltaTime*2);
            transform.eulerAngles = new Vector3(0, 0, zRotation);
            // print(transform.eulerAngles.z + " " + " " + zRotation);
        }

        float finalAngleval;
        void AssignResult()
        {
            canSpin = false;
            finalAngleval = transform.eulerAngles.z;

            // print((int)finalAngleval);



            switch ((int)finalAngleval)
            {
                case 0:
                case 1:
                    RewardAssign("Lose A Turn");
                    break;
                case 344:
                case 345:
                    RewardAssign("300");
                    break;
                case 329:
                case 330:
                    RewardAssign("400");
                    break;
                case 314:
                case 315:
                    RewardAssign("600");
                    break;
                case 300:
                case 301:
                    RewardAssign("Bank Rupp");
                    break;
                case 284:
                case 285:
                    RewardAssign("900");
                    break;
                case 269:
                case 270:
                    RewardAssign("spin 00");
                    break;
                case 254:
                case 255:
                    RewardAssign("500");
                    break;
                case 240:
                case 241:
                    RewardAssign("900");
                    break;
                case 223:
                case 224:
                    RewardAssign("300");
                    break;
                case 211:
                case 212:
                    RewardAssign("400");
                    break;
                case 194:
                case 195:
                    RewardAssign("550");
                    break;
                case 180:
                case 181:
                    RewardAssign("800");
                    break;
                case 164:
                case 165:
                    RewardAssign("500");
                    break;
                case 149:
                case 150:
                    RewardAssign("300");
                    break;
                case 134:
                case 135:
                    RewardAssign("600");
                    break;
                case 119:
                case 120:
                    RewardAssign("300");
                    break;
                case 105:
                case 106:
                    RewardAssign("5000");
                    break;
                case 90:
                case 91:
                    RewardAssign("600");
                    break;
                case 74:
                case 75:
                    RewardAssign("300");
                    break;
                case 59:
                case 60:
                    RewardAssign("700");
                    break;
                case 44:
                case 45:
                    RewardAssign("450");
                    break;
                case 30:
                case 31:
                    RewardAssign("350");
                    break;
                case 14:
                case 15:
                    RewardAssign("800");

                    break;

            }

        }

        void RewardAssign(string _reward)
        {
            txt_Reward.text = "Reward  :" + _reward;
            btn.interactable = true;
        }
    }
}
