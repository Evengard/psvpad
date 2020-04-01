// Decompiled with JetBrains decompiler
// Type: PSV_Server.InputEmulation
// Assembly: PSV_Server, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 99D27C4D-1970-4CC0-8120-423D0430A7B5
// Assembly location: I:\dev\psvpad_complete\PSVPAD Server\PSV_Server.exe

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace PSV_Server
{
    internal class InputEmulation
    {
        private Dictionary<string, uint> keyCodes = new Dictionary<string, uint>((IEqualityComparer<string>)StringComparer.InvariantCultureIgnoreCase);
        private Dictionary<string, uint> mouseCodes = new Dictionary<string, uint>((IEqualityComparer<string>)StringComparer.InvariantCultureIgnoreCase);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        internal static extern int MapVirtualKey(int uCode, int uMapType);

        [DllImport("user32.dll")]
        internal static extern uint SendInput(uint nInputs, [MarshalAs(UnmanagedType.LPArray), In] InputEmulation.INPUT[] pInputs, int cbSize);

        public InputEmulation()
        {
            this.initialise();
        }

        private void initialise()
        {
            this.keyCodes.Add("LButton", 1U);
            this.keyCodes.Add("RButton", 2U);
            this.keyCodes.Add("Cancel", 3U);
            this.keyCodes.Add("MButton", 4U);
            this.keyCodes.Add("XButton1", 5U);
            this.keyCodes.Add("XButton2", 6U);
            this.keyCodes.Add("Backspace", 8U);
            this.keyCodes.Add("Tab", 9U);
            this.keyCodes.Add("Clear", 12U);
            this.keyCodes.Add("Enter", 13U);
            this.keyCodes.Add("Shift", 16U);
            this.keyCodes.Add("Control", 17U);
            this.keyCodes.Add("Alt", 18U);
            this.keyCodes.Add("Pause", 19U);
            this.keyCodes.Add("Capslock", 20U);
            this.keyCodes.Add("Kana", 21U);
            this.keyCodes.Add("Hangul", 21U);
            this.keyCodes.Add("Junja", 23U);
            this.keyCodes.Add("Final", 24U);
            this.keyCodes.Add("Hanja", 25U);
            this.keyCodes.Add("Kanji", 25U);
            this.keyCodes.Add("Escape", 27U);
            this.keyCodes.Add("Esc", 27U);
            this.keyCodes.Add("Convert", 28U);
            this.keyCodes.Add("Nonconvert", 29U);
            this.keyCodes.Add("Accept", 30U);
            this.keyCodes.Add("Modechange", 31U);
            this.keyCodes.Add("Space", 32U);
            this.keyCodes.Add("Pgup", 33U);
            this.keyCodes.Add("Pgdn", 34U);
            this.keyCodes.Add("End", 35U);
            this.keyCodes.Add("Home", 36U);
            this.keyCodes.Add("Left", 37U);
            this.keyCodes.Add("Up", 38U);
            this.keyCodes.Add("Right", 39U);
            this.keyCodes.Add("Down", 40U);
            this.keyCodes.Add("Select", 41U);
            this.keyCodes.Add("Print", 42U);
            this.keyCodes.Add("Execute", 43U);
            this.keyCodes.Add("Prtscr", 44U);
            this.keyCodes.Add("Insert", 45U);
            this.keyCodes.Add("Delete", 46U);
            this.keyCodes.Add("Del", 46U);
            this.keyCodes.Add("Help", 47U);
            this.keyCodes.Add("Win", 91U);
            this.keyCodes.Add("LWin", 91U);
            this.keyCodes.Add("RWin", 92U);
            this.keyCodes.Add("Apps", 93U);
            this.keyCodes.Add("Sleep", 95U);
            this.keyCodes.Add("Num0", 96U);
            this.keyCodes.Add("Num1", 97U);
            this.keyCodes.Add("Num2", 98U);
            this.keyCodes.Add("Num3", 99U);
            this.keyCodes.Add("Num4", 100U);
            this.keyCodes.Add("Num5", 101U);
            this.keyCodes.Add("Num6", 102U);
            this.keyCodes.Add("Num7", 103U);
            this.keyCodes.Add("Num8", 104U);
            this.keyCodes.Add("Num9", 105U);
            this.keyCodes.Add("F1", 112U);
            this.keyCodes.Add("F2", 113U);
            this.keyCodes.Add("F3", 114U);
            this.keyCodes.Add("F4", 115U);
            this.keyCodes.Add("F5", 116U);
            this.keyCodes.Add("F6", 117U);
            this.keyCodes.Add("F7", 118U);
            this.keyCodes.Add("F8", 119U);
            this.keyCodes.Add("F9", 120U);
            this.keyCodes.Add("F10", 121U);
            this.keyCodes.Add("F11", 122U);
            this.keyCodes.Add("F12", 123U);
            this.keyCodes.Add("Numlock", 144U);
            this.keyCodes.Add("Scrolllock", 145U);
            this.keyCodes.Add("LShift", 160U);
            this.keyCodes.Add("RShift", 161U);
            this.keyCodes.Add("LCtrl", 162U);
            this.keyCodes.Add("RCtrl", 163U);
            this.keyCodes.Add("0", 48U);
            this.keyCodes.Add("1", 49U);
            this.keyCodes.Add("2", 50U);
            this.keyCodes.Add("3", 51U);
            this.keyCodes.Add("4", 52U);
            this.keyCodes.Add("5", 53U);
            this.keyCodes.Add("6", 54U);
            this.keyCodes.Add("7", 55U);
            this.keyCodes.Add("8", 56U);
            this.keyCodes.Add("9", 57U);
            this.keyCodes.Add("a", 65U);
            this.keyCodes.Add("b", 66U);
            this.keyCodes.Add("c", 67U);
            this.keyCodes.Add("d", 68U);
            this.keyCodes.Add("e", 69U);
            this.keyCodes.Add("f", 70U);
            this.keyCodes.Add("g", 71U);
            this.keyCodes.Add("h", 72U);
            this.keyCodes.Add("i", 73U);
            this.keyCodes.Add("j", 74U);
            this.keyCodes.Add("k", 75U);
            this.keyCodes.Add("l", 76U);
            this.keyCodes.Add("m", 77U);
            this.keyCodes.Add("n", 78U);
            this.keyCodes.Add("o", 79U);
            this.keyCodes.Add("p", 80U);
            this.keyCodes.Add("q", 81U);
            this.keyCodes.Add("r", 82U);
            this.keyCodes.Add("s", 83U);
            this.keyCodes.Add("t", 84U);
            this.keyCodes.Add("u", 85U);
            this.keyCodes.Add("v", 86U);
            this.keyCodes.Add("w", 87U);
            this.keyCodes.Add("x", 88U);
            this.keyCodes.Add("y", 89U);
            this.keyCodes.Add("z", 90U);
            this.keyCodes.Add(";", 186U);
            this.keyCodes.Add("=", 187U);
            this.keyCodes.Add("-", 189U);
            this.keyCodes.Add("/", 191U);
            this.keyCodes.Add("'", 192U);
            this.keyCodes.Add("[", 219U);
            this.keyCodes.Add("\\", 220U);
            this.keyCodes.Add("]", 221U);
            this.keyCodes.Add("#", 222U);
            this.keyCodes.Add(",", 188U);
            this.keyCodes.Add(".", 190U);
            this.mouseCodes.Add("LClick", 1U);
            this.mouseCodes.Add("RClick", 2U);
            this.mouseCodes.Add("MClick", 4U);
            this.mouseCodes.Add("XClick1", 8U);
            this.mouseCodes.Add("XClick2", 22U);
            this.mouseCodes.Add("ScrollUp", 50U);
            this.mouseCodes.Add("ScrollDown", 100U);
            this.mouseCodes.Add("MoveLeft", 296U);
            this.mouseCodes.Add("MoveRight", 598U);
            this.mouseCodes.Add("MoveUp", 1298U);
            this.mouseCodes.Add("MoveDown", 4132U);
        }

        public void sendInput(string input, bool keyDown)
        {
            if (input.Length == 0)
                return;
            bool flag1 = false;
            bool flag2 = false;
            bool flag3 = false;
            if (input[0] == '+' || input[0] == '%' || input[0] == '^')
            {
                for (int index = 0; index < 3 && (index < input.Length && input[index] != '(') && input[index] != '{'; ++index)
                {
                    if (input[index] == '+')
                        flag1 = true;
                    if (input[index] == '%')
                        flag2 = true;
                    if (input[index] == '^')
                        flag3 = true;
                }
            }
            int sourceIndex = 0;
            int num = 0;
            for (int index = 0; index < input.Length; ++index)
            {
                if (input[index] == '{' || input[index] == '(')
                    sourceIndex = index + 1;
                if (input[index] == '}' || input[index] == ')')
                {
                    num = index;
                    break;
                }
            }
            if (sourceIndex == 0 || num == 0)
                return;
            char[] destination = new char[num - sourceIndex];
            input.CopyTo(sourceIndex, destination, 0, num - sourceIndex);
            string key = new string(destination);
            if (keyDown)
            {
                if (flag3)
                    this.sendKeyDown(this.keyCodes["LCtrl"]);
                if (flag2)
                    this.sendKeyDown(this.keyCodes["Alt"]);
                if (flag1)
                    this.sendKeyDown(this.keyCodes["Shift"]);
                if (!this.keyCodes.ContainsKey(key))
                    return;
                this.sendKeyDown(this.keyCodes[key]);
            }
            else
            {
                if (flag3)
                    this.sendKeyUp(this.keyCodes["LCtrl"]);
                if (flag2)
                    this.sendKeyDown(this.keyCodes["Alt"]);
                if (flag1)
                    this.sendKeyUp(this.keyCodes["Shift"]);
                if (!this.keyCodes.ContainsKey(key))
                    return;
                this.sendKeyUp(this.keyCodes[key]);
            }
        }

        public void sendKeyDown(uint keyCode)
        {
            InputEmulation.INPUT[] pInputs = new InputEmulation.INPUT[1];
            pInputs[0].type = 1U;
            pInputs[0].input.ki.dwFlags = 8U;
            pInputs[0].input.ki.wScan = (short)InputEmulation.MapVirtualKey((int)keyCode, 0);
            pInputs[0].input.ki.time = 0;
            int num = (int)InputEmulation.SendInput(1U, pInputs, InputEmulation.INPUT.Size);
        }

        public void sendKeyUp(uint keyCode)
        {
            InputEmulation.INPUT[] pInputs = new InputEmulation.INPUT[1];
            pInputs[0].type = 1U;
            pInputs[0].input.ki.dwFlags = 10U;
            pInputs[0].input.ki.wScan = (short)InputEmulation.MapVirtualKey((int)keyCode, 0);
            pInputs[0].input.ki.time = 0;
            int num = (int)InputEmulation.SendInput(1U, pInputs, InputEmulation.INPUT.Size);
        }

        public void sendMouseInput(string input, bool keyDown, float keyVal)
        {
            int num1 = 120;
            float num2 = 8f * Math.Abs(keyVal);
            if (!this.mouseCodes.ContainsKey(input))
                return;
            uint mouseCode = this.mouseCodes[input];
            int num3 = 0;
            int num4 = 0;
            uint num5 = 0;
            uint num6 = 0;
            if (keyDown)
            {
                if (mouseCode <= 22U)
                {
                    switch (mouseCode)
                    {
                        case 1:
                            num6 |= 2U;
                            break;
                        case 2:
                            num6 |= 8U;
                            break;
                        case 4:
                            num6 |= 32U;
                            break;
                        case 8:
                            num6 |= 128U;
                            num5 = 1U;
                            break;
                        case 22:
                            num6 |= 128U;
                            num5 = 1U;
                            break;
                    }
                }
                else if (mouseCode <= 100U)
                {
                    switch (mouseCode)
                    {
                        case 50:
                            num6 |= 2048U;
                            num5 = (uint)num1;
                            break;
                        case 100:
                            num6 |= 2048U;
                            num5 = (uint)-num1;
                            break;
                    }
                }
                else
                {
                    num6 |= 1U;
                    switch (mouseCode)
                    {
                        case 296:
                            num3 = (int)-(double)num2;
                            break;
                        case 598:
                            num3 = (int)num2;
                            break;
                        case 1298:
                            num4 = (int)-(double)num2;
                            break;
                        case 4132:
                            num4 = (int)num2;
                            break;
                    }
                }
            }
            else if (mouseCode <= 16U)
            {
                switch (mouseCode)
                {
                    case 1:
                        num6 |= 4U;
                        break;
                    case 2:
                        num6 |= 16U;
                        break;
                    case 4:
                        num6 |= 64U;
                        break;
                    case 8:
                        num6 |= 256U;
                        num5 = 1U;
                        break;
                    case 22:
                        num6 |= 256U;
                        num5 = 1U;
                        break;
                }
            }
            InputEmulation.INPUT[] pInputs = new InputEmulation.INPUT[1];
            pInputs[0].type = 0U;
            pInputs[0].input.mi.dx = num3;
            pInputs[0].input.mi.dy = num4;
            pInputs[0].input.mi.mouseData = num5;
            pInputs[0].input.mi.dwFlags = num6;
            pInputs[0].input.mi.time = 0U;
            int num7 = (int)InputEmulation.SendInput(1U, pInputs, InputEmulation.INPUT.Size);
        }

        public struct INPUT
        {
            internal uint type;
            internal InputEmulation.IUnion input;

            internal static int Size
            {
                get
                {
                    return Marshal.SizeOf(typeof(InputEmulation.INPUT));
                }
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        internal struct IUnion
        {
            [FieldOffset(0)]
            internal InputEmulation.MOUSEINPUT mi;
            [FieldOffset(0)]
            internal InputEmulation.KEYBDINPUT ki;
            [FieldOffset(0)]
            internal InputEmulation.HARDWAREINPUT hi;
        }

        internal struct KEYBDINPUT
        {
            internal short wVk;
            internal short wScan;
            internal uint dwFlags;
            internal int time;
            internal UIntPtr dwExtraInfo;
        }

        internal struct MOUSEINPUT
        {
            internal int dx;
            internal int dy;
            internal uint mouseData;
            internal uint dwFlags;
            internal uint time;
            internal UIntPtr dwExtraInfo;
        }

        internal struct HARDWAREINPUT
        {
            internal int uMsg;
            internal short wParamL;
            internal short wParamH;
        }

        private enum MapType : uint
        {
            MAPVK_VK_TO_VSC,
            MAPVK_VSC_TO_VK,
            MAPVK_VK_TO_CHAR,
            MAPVK_VSC_TO_VK_EX,
        }

        private enum InputType : uint
        {
            INPUT_MOUSE,
            INPUT_KEYBOARD,
            INPUT_HARDWARE,
        }

        private enum KeyboardFlags : uint
        {
            KEYEVENTF_EXTENDEDKEY = 1,
            KEYEVENTF_KEYUP = 2,
            KEYEVENTF_UNICODE = 4,
            KEYEVENTF_SCANCODE = 8,
        }

        private enum MouseFlags : uint
        {
            MOUSEEVENTF_MOVE = 1,
            MOUSEEVENTF_LEFTDOWN = 2,
            MOUSEEVENTF_LEFTUP = 4,
            MOUSEEVENTF_RIGHTDOWN = 8,
            MOUSEEVENTF_RIGHTUP = 16, // 0x00000010
            MOUSEEVENTF_MIDDLEDOWN = 32, // 0x00000020
            MOUSEEVENTF_MIDDLEUP = 64, // 0x00000040
            MOUSEEVENTF_XDOWN = 128, // 0x00000080
            MOUSEEVENTF_XUP = 256, // 0x00000100
            MOUSEEVENTF_WHEEL = 2048, // 0x00000800
            MOUSEEVENTF_HWHEEL = 4096, // 0x00001000
            MOUSEEVENTF_MOVE_NOCOALESCE = 8192, // 0x00002000
            MOUSEEVENTF_VIRTUALDESK = 16384, // 0x00004000
            MOUSEEVENTF_ABSOLUTE = 32768, // 0x00008000
        }

        private enum MouseCodes : uint
        {
            LEFT_CLICK = 1,
            RIGHT_CLICK = 2,
            MIDDLE_CLICK = 4,
            X_CLICK_1 = 8,
            X_CLICK_2 = 22, // 0x00000016
            SCROLL_UP = 50, // 0x00000032
            SCROLL_DOWN = 100, // 0x00000064
            MOVE_LEFT = 296, // 0x00000128
            MOVE_RIGHT = 598, // 0x00000256
            MOVE_UP = 1298, // 0x00000512
            MOVE_DOWN = 4132, // 0x00001024
        }
    }
}
