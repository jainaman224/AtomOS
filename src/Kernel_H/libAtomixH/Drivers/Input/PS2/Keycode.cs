﻿using System;

namespace libAtomixH.Drivers.Input.PS2
{
    /// <summary>
    /// List ref: http://www.computer-engineering.org/ps2keyboard/scancodes1.html
    /// </summary>
    public enum KeyCode
    {
        //Only static buttons goes here
        A = 0, D0 = 26, Backtick = 36, F1 = 46, Prtsc = 58, NumDivide = 77, NextTrack = 93,
        B = 1, D1 = 27, Dash = 37, F2 = 47, Pause = 59, NumMultiply = 78, PrevTrack = 94,
        C = 2, D2 = 28, Equals = 38, F3 = 48, OpenBracket = 60, NumSubtract = 79, Stop = 95,
        D = 3, D3 = 29, Backslash = 39, F4 = 49, Insert = 61, NumAdd = 80, Play = 96,
        E = 4, D4 = 30, Backspace = 40, F5 = 50, Home = 62, NumEnter = 81, Mute = 97,
        F = 5, D5 = 31, Space = 41, F6 = 51, PageUP = 63, NumDecimal = 82, VolumeUp = 98,
        G = 6, D6 = 32, Tab = 42, F7 = 52, Delete = 64, Num0 = 83, VolumeDown = 99,
        H = 7, D7 = 33, LCtrl = 112, F8 = 53, End = 65, Num1 = 84, MediaSelect = 100,
        I = 8, D8 = 34, Apps = 43, F9 = 54, PageDown = 66, Num2 = 85, Email = 101,
        J = 9, D9 = 35, Enter = 44, F10 = 55, CursorUp = 67, Num3 = 86, Calculator = 102,
        K = 10, Esc = 45, F11 = 56, CursorDown = 68, Num4 = 87, MyComputer = 103,
        L = 11, LShift = 113, F12 = 57, CursorLeft = 69, Num5 = 88, WWWSearch = 104,
        M = 12, RShift = 114, CursorRight = 70, Num6 = 89, WWWHome = 105,
        N = 13, LAlt = 115, CloseBracket = 71, Num7 = 90, WWWBack = 106,
        O = 14, Caps = 116, SemiColon = 72, Num8 = 91, WWWForward = 107,
        P = 15, Num = 117, Singlequote = 73, Num9 = 92, WWWStop = 108,
        Q = 16, Scroll = 118, Comma = 74, WWWRefresh = 109,
        R = 17, RCtrl = 119, FullStop = 75, WWWFavorites = 110,
        S = 18, RAlt = 120, ForwardSlash = 76, None = 111,
        T = 19, LGUI = 121,
        U = 20, RGUI = 122,
        V = 21,
        W = 22,
        X = 23,
        Y = 24,
        Z = 25,
    };
}
