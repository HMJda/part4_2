using System;
public delegate void MyEventHandler(); // ② 이벤트를 위한 델리게이트 정의
class Button
{
    public event MyEventHandler Push; // ③ 이벤트 선언(클래스 내)
    public void OnPush()
    {
        if (Push != null)
            Push(); // ⑤ 이벤트 발생
    }
}
class EventHandlerClass
{
    public void MyMethod()
    { // ① 이벤트 처리기 작성
        Console.WriteLine("In the EventHandlerClass.MyMethod ...");
    }
}
class EventHandlingApp
{
    public static void Main()
    {
        Button button = new Button(); // event가 포함된 Button 객체 생성
        EventHandlerClass obj = new EventHandlerClass(); // event handler를 포함한 객체 생성
        button.Push += new MyEventHandler(obj.MyMethod); // ④ 등록 (event에 이벤트 처리기 등록)
        button.OnPush(); // event를 발생: OnPush() 메소드 실행 (➔ Push() 호출: 이벤트 발생)
    } //event 는 등록이 = 이 아닌 += 임 
}