﻿#pragma checksum "..\..\AuthPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "CE14904877CF7E5B8C50787E53B13B344EB835E894A2E9B5994F777BDEA918F3"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using BaranovSize41;
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


namespace BaranovSize41 {
    
    
    /// <summary>
    /// AuthPage
    /// </summary>
    public partial class AuthPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 23 "..\..\AuthPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextLog;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\AuthPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextPass;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\AuthPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button GuestButton;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\AuthPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button EnterButton;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/BaranovSize41;component/authpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AuthPage.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.TextLog = ((System.Windows.Controls.TextBox)(target));
            
            #line 23 "..\..\AuthPage.xaml"
            this.TextLog.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextLog_TextChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.TextPass = ((System.Windows.Controls.TextBox)(target));
            
            #line 24 "..\..\AuthPage.xaml"
            this.TextPass.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextPass_TextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.GuestButton = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\AuthPage.xaml"
            this.GuestButton.Click += new System.Windows.RoutedEventHandler(this.GuestButton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.EnterButton = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\AuthPage.xaml"
            this.EnterButton.Click += new System.Windows.RoutedEventHandler(this.EnterButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

