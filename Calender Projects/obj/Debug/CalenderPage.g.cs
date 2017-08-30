﻿#pragma checksum "..\..\CalenderPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "9725FCDDBFF9C22457C99BA535205205"
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
    /// CalenderWindow
    /// </summary>
    public partial class CalenderWindow : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 24 "..\..\CalenderPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label MonthLabel;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\CalenderPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label YearLabel;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\CalenderPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddEvent;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\CalenderPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid WeekDay;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\CalenderPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.UniformGrid Calender;
        
        #line default
        #line hidden
        
        
        #line 87 "..\..\CalenderPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ManageList;
        
        #line default
        #line hidden
        
        
        #line 93 "..\..\CalenderPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ListTitle;
        
        #line default
        #line hidden
        
        
        #line 97 "..\..\CalenderPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ListDescription;
        
        #line default
        #line hidden
        
        
        #line 102 "..\..\CalenderPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox ListCheckbox;
        
        #line default
        #line hidden
        
        
        #line 107 "..\..\CalenderPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox ChecklistCheckbox;
        
        #line default
        #line hidden
        
        
        #line 113 "..\..\CalenderPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ListLabel;
        
        #line default
        #line hidden
        
        
        #line 121 "..\..\CalenderPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SaveList;
        
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
            System.Uri resourceLocater = new System.Uri("/Calender Projects;component/calenderpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\CalenderPage.xaml"
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
            this.MonthLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.YearLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.AddEvent = ((System.Windows.Controls.Button)(target));
            
            #line 37 "..\..\CalenderPage.xaml"
            this.AddEvent.Click += new System.Windows.RoutedEventHandler(this.AddEvent_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.WeekDay = ((System.Windows.Controls.Grid)(target));
            return;
            case 5:
            this.Calender = ((System.Windows.Controls.Primitives.UniformGrid)(target));
            return;
            case 6:
            this.ManageList = ((System.Windows.Controls.Button)(target));
            
            #line 90 "..\..\CalenderPage.xaml"
            this.ManageList.Click += new System.Windows.RoutedEventHandler(this.ManageList_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.ListTitle = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.ListDescription = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.ListCheckbox = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 10:
            this.ChecklistCheckbox = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 11:
            this.ListLabel = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 12:
            this.SaveList = ((System.Windows.Controls.Button)(target));
            
            #line 123 "..\..\CalenderPage.xaml"
            this.SaveList.Click += new System.Windows.RoutedEventHandler(this.AddList_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

