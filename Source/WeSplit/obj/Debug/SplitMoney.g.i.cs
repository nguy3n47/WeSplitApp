﻿#pragma checksum "..\..\SplitMoney.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "7C522D2251DFC54F6D2D7A3412062AF8BE8AF0AB21223FFE3EEE14F84C4E1374"
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
using WeSplit;


namespace WeSplit {
    
    
    /// <summary>
    /// SplitMoney
    /// </summary>
    public partial class SplitMoney : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 20 "..\..\SplitMoney.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MaterialDesignThemes.Wpf.Transitions.TransitioningContent TrainsitionigContentSlide;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\SplitMoney.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DockPanel USSplitMoney;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\SplitMoney.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.WrapPanel Top;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\SplitMoney.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image TopImg;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\SplitMoney.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label TopLabel;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\SplitMoney.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imgCancel;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\SplitMoney.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Title;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\SplitMoney.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ItemsControl Itemscontrol;
        
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
            System.Uri resourceLocater = new System.Uri("/WeSplit;component/splitmoney.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\SplitMoney.xaml"
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
            
            #line 16 "..\..\SplitMoney.xaml"
            ((WeSplit.SplitMoney)(target)).Loaded += new System.Windows.RoutedEventHandler(this.UserControl_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.TrainsitionigContentSlide = ((MaterialDesignThemes.Wpf.Transitions.TransitioningContent)(target));
            return;
            case 3:
            this.USSplitMoney = ((System.Windows.Controls.DockPanel)(target));
            return;
            case 4:
            this.Top = ((System.Windows.Controls.WrapPanel)(target));
            return;
            case 5:
            this.TopImg = ((System.Windows.Controls.Image)(target));
            return;
            case 6:
            this.TopLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.imgCancel = ((System.Windows.Controls.Image)(target));
            
            #line 28 "..\..\SplitMoney.xaml"
            this.imgCancel.MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.imgCancel_MouseUp);
            
            #line default
            #line hidden
            return;
            case 8:
            this.Title = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 9:
            this.Itemscontrol = ((System.Windows.Controls.ItemsControl)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

