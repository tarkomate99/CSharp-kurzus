using System;
using System.Runtime.InteropServices;

namespace MessageBoxExample
{

    /*
       int MessageBox(
  [in, optional] HWND    hWnd,
  [in, optional] LPCTSTR lpText,
  [in, optional] LPCTSTR lpCaption,
  [in]           UINT    uType
);
     */

    internal class MessageBoxWrapper
    {
        [DllImport("User32.dll")]
        private static extern int MessageBox(IntPtr hWnd, string lpText, string lpCaption, uint uType);

        public static void ShowMessageBox(string content, string title, MessageBoxType type, MessageBoxIcon icon)
        {
            MessageBox(IntPtr.Zero, content, title, (uint)type |(uint)icon);
        }
    }

    public enum MessageBoxType
    { 
        AbortRetryIgnore = 0x00000002,
        CancelTryContinue = 0x00000006,
        Help = 0x00004000,
        Ok = 0x00000000,
        OkCancel = 0x00000001,
        RetryCancel = 0x00000005,
        YesNo = 0x00000004,
        YesNoCancel = 0x00000003,

    }

    public enum MessageBoxIcon : uint
    {
        IconExclamation = 0x00000030,
        Warning = 0x00000030,
        Information = 0x00000040,
        Asterisk = 0x00000040,
        Question = 0x00000020,
        Stop = 0x00000010,
        Error = 0x00000010,
        Hand = 0x00000010,
    }
}

/*
 * MB_ICONEXCLAMATION
0x00000030L
An exclamation-point icon appears in the message box.
MB_ICONWARNING
0x00000030L
An exclamation-point icon appears in the message box.
MB_ICONINFORMATION
0x00000040L
An icon consisting of a lowercase letter i in a circle appears in the message box.
MB_ICONASTERISK
0x00000040L
An icon consisting of a lowercase letter i in a circle appears in the message box.
MB_ICONQUESTION
0x00000020L
A question-mark icon appears in the message box. The question-mark message icon is no longer recommended because it does not clearly represent a specific type of message and because the phrasing of a message as a question could apply to any message type. In addition, users can confuse the message symbol question mark with Help information. Therefore, do not use this question mark message symbol in your message boxes. The system continues to support its inclusion only for backward compatibility.
MB_ICONSTOP
0x00000010L
A stop-sign icon appears in the message box.
MB_ICONERROR
0x00000010L
A stop-sign icon appears in the message box.
MB_ICONHAND
0x00000010L
A stop-sign icon appears in the message box.
 
To indicate the default button, specify one of the following values.

Value	Meaning
MB_DEFBUTTON1
0x00000000L
The first button is the default button.
MB_DEFBUTTON1 is the default unless MB_DEFBUTTON2, MB_DEFBUTTON3, or MB_DEFBUTTON4 is specified.

MB_DEFBUTTON2
0x00000100L
The second button is the default button.
MB_DEFBUTTON3
0x00000200L
The third button is the default button.
MB_DEFBUTTON4
0x00000300L
The fourth button is the default button.
 */
