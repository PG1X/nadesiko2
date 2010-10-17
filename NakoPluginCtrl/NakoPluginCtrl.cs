﻿using System;
using System.Collections.Generic;
using System.Text;

using NakoPlugin;
using System.Windows.Forms;
using Microsoft.VisualBasic;


namespace NakoPluginCtrl
{
    public class NakoPluginCtrl : INakoPlugin
    {
    	//--- プラグインの宣言 ---
    	string _description = "外部アプリとの連携を行うプラグイン";
    	double _version = 1.0;
        //--- プラグイン共通の部分 ---
    	public double TargetNakoVersion { get { return 2.0; } }
        public bool Used { get; set; }
        public string Name { get { return this.GetType().FullName; } }
        public double PluginVersion { get { return _version; } }
        public string Description { get { return _description; } }
        //--- 関数の定義 ---
        public void DefineFunction(INakoPluginBank bank)
        {
            bank.AddFunc("コピー", "Sを|Sの", NakoVarType.Void, _copyToClipboard, "文字列Sをクリップボードにコピーする", "こぴー");
            bank.AddFunc("クリップボード", "", NakoVarType.Void, _getFromClipboard, "クリップボードの文字列を取得する", "くりっぷぼーど");
            bank.AddFunc("キー送信", "KEYSを", NakoVarType.Void, _sendKeys, "ウィンドウのタイトルTITLEに文字列KEYSを送信する", "きーそうしん");
        }
            
        // Define Method
        public Object _copyToClipboard(INakoFuncCallInfo info)
        {
            String s = info.StackPopAsString();
            Clipboard.SetDataObject(s, true);
            return null;
        }

        public Object _getFromClipboard(INakoFuncCallInfo info)
        {
            return Clipboard.GetText();
        }

        public Object _sendKeys(INakoFuncCallInfo info)
        {
            String keys  = info.StackPopAsString();
            SendKeys.Send(keys);
            return null;
        }
        
    }
}
