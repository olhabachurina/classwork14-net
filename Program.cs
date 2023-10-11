// See https://aka.ms/new-console-template for more information
using classwork14_net;
using System.Runtime.CompilerServices;

    MyButton myButton = new MyButton("Red", 33, 45, "SOS");


    ButtonClickSubscriber subscriber = new ButtonClickSubscriber();


    myButton.OnClickButton += subscriber.OnButtonClick;


myButton.PressButton();
   

