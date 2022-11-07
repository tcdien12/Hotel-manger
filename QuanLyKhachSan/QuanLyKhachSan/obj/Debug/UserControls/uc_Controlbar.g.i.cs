﻿#pragma checksum "..\..\..\UserControls\uc_Controlbar.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "934B36B05B551B663847F363D2C1A565F58B71CBF10C04725D29ADAD64C853A1"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using GUI.UserControls;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
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


namespace GUI.UserControls {
    
    
    /// <summary>
    /// uc_Controlbar
    /// </summary>
    public partial class uc_Controlbar : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 8 "..\..\..\UserControls\uc_Controlbar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal GUI.UserControls.uc_Controlbar controlbar;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\UserControls\uc_Controlbar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MaterialDesignThemes.Wpf.ColorZone backGroum;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\UserControls\uc_Controlbar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_maximize;
        
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
            System.Uri resourceLocater = new System.Uri("/GUI;component/usercontrols/uc_controlbar.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\UserControls\uc_Controlbar.xaml"
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
            this.controlbar = ((GUI.UserControls.uc_Controlbar)(target));
            return;
            case 2:
            this.backGroum = ((MaterialDesignThemes.Wpf.ColorZone)(target));
            return;
            case 3:
            
            #line 24 "..\..\..\UserControls\uc_Controlbar.xaml"
            ((System.Windows.Controls.Grid)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Grid_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 47 "..\..\..\UserControls\uc_Controlbar.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Minimize);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btn_maximize = ((System.Windows.Controls.Button)(target));
            
            #line 59 "..\..\..\UserControls\uc_Controlbar.xaml"
            this.btn_maximize.Click += new System.Windows.RoutedEventHandler(this.Button_Maximize);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 70 "..\..\..\UserControls\uc_Controlbar.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Close);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

