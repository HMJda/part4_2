using System;
using System.Windows.Forms;
class ClickEventApp : Form
{
    public ClickEventApp()
    { // 생성자
        this.Text = "ClickEventApp";
        this.Click += new EventHandler(ClickEvent); //  등록
    }
    // ... 이벤트 처리기 ...
    private void ClickEvent(object sender, EventArgs e)
    {
        MessageBox.Show(" sender = " + sender.GetType());
    }
    public static void Main()
    {
        Application.Run(new ClickEventApp());
    }
}