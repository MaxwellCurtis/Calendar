﻿#pragma checksum "..\..\AddEventPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "568EA6320199F78B482CAE215D4F667A"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Calender_Projects;
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


namespace Calender_Projects {
    
    
    /// <summary>
    /// CreateEventPage
    /// </summary>
    public partial class CreateEventPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 25 "..\..\AddEventPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SaveEvent;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\AddEventPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button GoBackEvent;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\AddEventPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock messages;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\AddEventPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label EventNameLabel;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\AddEventPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox EventName;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\AddEventPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label StartLabel;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\AddEventPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox StartBox;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\AddEventPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label EndLabel;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\AddEventPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox EndBox;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\AddEventPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label DescLabel;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\AddEventPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox DescriptionBox;
        
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
            System.Uri resourceLocater = new System.Uri("/Calender Projects;component/addeventpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AddEventPage.xaml"
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
            this.SaveEvent = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\AddEventPage.xaml"
            this.SaveEvent.Click += new System.Windows.RoutedEventHandler(this.SaveEvent_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.GoBackEvent = ((System.Windows.Controls.Button)(target));
            
            #line 32 "..\..\AddEventPage.xaml"
            this.GoBackEvent.Click += new System.Windows.RoutedEventHandler(this.GoBackEvent_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.messages = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.EventNameLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.EventName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.StartLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.StartBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 8:
            this.EndLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 9:
            this.EndBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 66 "..\..\AddEventPage.xaml"
            this.EndBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.EndBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 10:
            this.DescLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 11:
            this.DescriptionBox = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

