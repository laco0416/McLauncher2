﻿#pragma checksum "..\..\..\SettingWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "2E52243379B22385711588A53FAAEBC4"
//------------------------------------------------------------------------------
// <auto-generated>
//     このコードはツールによって生成されました。
//     ランタイム バージョン:4.0.30319.269
//
//     このファイルへの変更は、以下の状況下で不正な動作の原因になったり、
//     コードが再生成されるときに損失したりします。
// </auto-generated>
//------------------------------------------------------------------------------

using McLauncher2;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace McLauncher2 {
    
    
    /// <summary>
    /// SettingWindow
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
    public partial class SettingWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 26 "..\..\..\SettingWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Button_Exit;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\SettingWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Button_Log;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\..\SettingWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Button_NoUpdate;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\..\SettingWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_ok;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/McLauncher2;component/settingwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\SettingWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 6 "..\..\..\SettingWindow.xaml"
            ((McLauncher2.SettingWindow)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Button_Exit = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\..\SettingWindow.xaml"
            this.Button_Exit.Click += new System.Windows.RoutedEventHandler(this.Button_Exit_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Button_Log = ((System.Windows.Controls.Button)(target));
            
            #line 59 "..\..\..\SettingWindow.xaml"
            this.Button_Log.Click += new System.Windows.RoutedEventHandler(this.Button_Log_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Button_NoUpdate = ((System.Windows.Controls.Button)(target));
            
            #line 70 "..\..\..\SettingWindow.xaml"
            this.Button_NoUpdate.Click += new System.Windows.RoutedEventHandler(this.Button_Log_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.button_ok = ((System.Windows.Controls.Button)(target));
            
            #line 82 "..\..\..\SettingWindow.xaml"
            this.button_ok.Click += new System.Windows.RoutedEventHandler(this.Button_Ok_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

