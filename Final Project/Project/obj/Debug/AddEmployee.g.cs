﻿#pragma checksum "..\..\AddEmployee.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "058FF654EC48805BB2ED7182132CA0B3E96463037E44B97DFB0C9B8A18F0E8AA"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
using Project;
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


namespace Project {
    
    
    /// <summary>
    /// AddEmployee
    /// </summary>
    public partial class AddEmployee : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 30 "..\..\AddEmployee.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button MinimizeBtn;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\AddEmployee.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button MaximizeBtn;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\AddEmployee.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button closeBtn;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\AddEmployee.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtName;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\AddEmployee.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtEmail;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\AddEmployee.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtPhoneNumber;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\AddEmployee.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox txtPassword;
        
        #line default
        #line hidden
        
        
        #line 74 "..\..\AddEmployee.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtSalary;
        
        #line default
        #line hidden
        
        
        #line 78 "..\..\AddEmployee.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button PayBtn;
        
        #line default
        #line hidden
        
        
        #line 79 "..\..\AddEmployee.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BackBtn;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\AddEmployee.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image ProfileImg;
        
        #line default
        #line hidden
        
        
        #line 82 "..\..\AddEmployee.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ChoosePhotoBtn;
        
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
            System.Uri resourceLocater = new System.Uri("/Project;component/addemployee.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AddEmployee.xaml"
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
            this.MinimizeBtn = ((System.Windows.Controls.Button)(target));
            
            #line 30 "..\..\AddEmployee.xaml"
            this.MinimizeBtn.Click += new System.Windows.RoutedEventHandler(this.MinimizeBtn_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.MaximizeBtn = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\AddEmployee.xaml"
            this.MaximizeBtn.Click += new System.Windows.RoutedEventHandler(this.MaximizeBtn_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.closeBtn = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\AddEmployee.xaml"
            this.closeBtn.Click += new System.Windows.RoutedEventHandler(this.CloseBtn_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.txtName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.txtEmail = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.txtPhoneNumber = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.txtPassword = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 8:
            this.txtSalary = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.PayBtn = ((System.Windows.Controls.Button)(target));
            
            #line 78 "..\..\AddEmployee.xaml"
            this.PayBtn.Click += new System.Windows.RoutedEventHandler(this.PayClick);
            
            #line default
            #line hidden
            return;
            case 10:
            this.BackBtn = ((System.Windows.Controls.Button)(target));
            
            #line 79 "..\..\AddEmployee.xaml"
            this.BackBtn.Click += new System.Windows.RoutedEventHandler(this.BackBtn_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.ProfileImg = ((System.Windows.Controls.Image)(target));
            return;
            case 12:
            this.ChoosePhotoBtn = ((System.Windows.Controls.Button)(target));
            
            #line 82 "..\..\AddEmployee.xaml"
            this.ChoosePhotoBtn.Click += new System.Windows.RoutedEventHandler(this.ChoosePhotoBtn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

