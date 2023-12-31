﻿#pragma checksum "..\..\UserInformations.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "F707150A30B02E1B53F5D1F7D0C6A855DF76FC394B7493B6ED984889F218F909"
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
    /// UserInformations
    /// </summary>
    public partial class UserInformations : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 32 "..\..\UserInformations.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button MinimizeBtn;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\UserInformations.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button MaximizeBtn;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\UserInformations.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button closeBtn;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\UserInformations.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image ImageFile;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\UserInformations.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtName;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\UserInformations.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtEmail;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\UserInformations.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtPhone;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\UserInformations.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtRegistration;
        
        #line default
        #line hidden
        
        
        #line 86 "..\..\UserInformations.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtSubscription;
        
        #line default
        #line hidden
        
        
        #line 93 "..\..\UserInformations.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtRemainingDays;
        
        #line default
        #line hidden
        
        
        #line 99 "..\..\UserInformations.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView ListOfBooks;
        
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
            System.Uri resourceLocater = new System.Uri("/Project;component/userinformations.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\UserInformations.xaml"
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
            
            #line 32 "..\..\UserInformations.xaml"
            this.MinimizeBtn.Click += new System.Windows.RoutedEventHandler(this.MinimizeBtn_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.MaximizeBtn = ((System.Windows.Controls.Button)(target));
            
            #line 35 "..\..\UserInformations.xaml"
            this.MaximizeBtn.Click += new System.Windows.RoutedEventHandler(this.MaximizeBtn_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.closeBtn = ((System.Windows.Controls.Button)(target));
            
            #line 38 "..\..\UserInformations.xaml"
            this.closeBtn.Click += new System.Windows.RoutedEventHandler(this.CloseBtn_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ImageFile = ((System.Windows.Controls.Image)(target));
            return;
            case 5:
            this.txtName = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.txtEmail = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.txtPhone = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 8:
            this.txtRegistration = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 9:
            this.txtSubscription = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 10:
            this.txtRemainingDays = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 11:
            this.ListOfBooks = ((System.Windows.Controls.ListView)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

