#pragma checksum "..\..\..\View\Them_SuaPhong.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "5A1D32E3AEC81E17795C1ADDDF438411F8DE8F49657426DC273F31F536CDD795"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using GUI.View;
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


namespace GUI.View {
    
    
    /// <summary>
    /// Them_SuaPhong
    /// </summary>
    public partial class Them_SuaPhong : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 29 "..\..\..\View\Them_SuaPhong.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txbTitle;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\..\View\Them_SuaPhong.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtSoPhong;
        
        #line default
        #line hidden
        
        
        #line 85 "..\..\..\View\Them_SuaPhong.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbTinhTrang;
        
        #line default
        #line hidden
        
        
        #line 112 "..\..\..\View\Them_SuaPhong.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbLoaiPhong;
        
        #line default
        #line hidden
        
        
        #line 138 "..\..\..\View\Them_SuaPhong.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCapNhat;
        
        #line default
        #line hidden
        
        
        #line 168 "..\..\..\View\Them_SuaPhong.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnHuy;
        
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
            System.Uri resourceLocater = new System.Uri("/GUI;component/view/them_suaphong.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\View\Them_SuaPhong.xaml"
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
            this.txbTitle = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.txtSoPhong = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.cmbTinhTrang = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            this.cmbLoaiPhong = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            this.btnCapNhat = ((System.Windows.Controls.Button)(target));
            
            #line 138 "..\..\..\View\Them_SuaPhong.xaml"
            this.btnCapNhat.Click += new System.Windows.RoutedEventHandler(this.btnCapNhat_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 147 "..\..\..\View\Them_SuaPhong.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnThem_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btnHuy = ((System.Windows.Controls.Button)(target));
            
            #line 168 "..\..\..\View\Them_SuaPhong.xaml"
            this.btnHuy.Click += new System.Windows.RoutedEventHandler(this.btnHuy_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

