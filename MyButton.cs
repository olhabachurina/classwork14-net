using classwork14_net;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;


public class MyButton
{
    
    public string Color { get; set; }
    public int Width { get; set; }
    public int Height { get; set; }
    public string Text { get; set; }

    
    public event EventHandler<ButtonEventArgs> OnClickButton;

    
    public MyButton(string color, int width, int height, string text)
    {
        Color = color;
        Width = width;
        Height = height;
        Text = text;
    }

    
    public void PressButton()
    {
        Console.WriteLine("Button pressed!");
        ClickButton();
    }

    
    protected virtual void ClickButton()
    {
        var args = new ButtonEventArgs(DateTime.Now);
        OnClickButton?.Invoke(this, args);
    }
}