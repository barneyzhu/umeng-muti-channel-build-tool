﻿#pragma checksum "..\..\ChannelTool.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "6A06386813E17B5DE0FE964DFADBD818"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.296
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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
using UmengPackage;
using UmengPackage.Source.Model;


namespace UmengPackage {
    
    
    /// <summary>
    /// ChannelTool
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
    public partial class ChannelTool : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 9 "..\..\ChannelTool.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal UmengPackage.ChannelTool tool;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\ChannelTool.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas image1;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\ChannelTool.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label hint;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\ChannelTool.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock ChannelName;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\ChannelTool.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox settingList;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\ChannelTool.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button1;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\ChannelTool.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox Channels;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\ChannelTool.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_builder;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\ChannelTool.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.GroupBox groupBox1;
        
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
            System.Uri resourceLocater = new System.Uri("/UmengPackage;component/channeltool.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ChannelTool.xaml"
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
            this.tool = ((UmengPackage.ChannelTool)(target));
            return;
            case 2:
            this.image1 = ((System.Windows.Controls.Canvas)(target));
            
            #line 27 "..\..\ChannelTool.xaml"
            this.image1.AddHandler(System.Windows.DragDrop.DragEnterEvent, new System.Windows.DragEventHandler(this.dragDrop_Event));
            
            #line default
            #line hidden
            
            #line 28 "..\..\ChannelTool.xaml"
            this.image1.AddHandler(System.Windows.DragDrop.DropEvent, new System.Windows.DragEventHandler(this.dragDrop_Event));
            
            #line default
            #line hidden
            
            #line 29 "..\..\ChannelTool.xaml"
            this.image1.AddHandler(System.Windows.DragDrop.DragOverEvent, new System.Windows.DragEventHandler(this.dragDrop_Event));
            
            #line default
            #line hidden
            
            #line 30 "..\..\ChannelTool.xaml"
            this.image1.AddHandler(System.Windows.DragDrop.DragLeaveEvent, new System.Windows.DragEventHandler(this.dragDrop_Event));
            
            #line default
            #line hidden
            return;
            case 3:
            this.hint = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.ChannelName = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.settingList = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 6:
            this.button1 = ((System.Windows.Controls.Button)(target));
            
            #line 42 "..\..\ChannelTool.xaml"
            this.button1.Click += new System.Windows.RoutedEventHandler(this.edit_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.Channels = ((System.Windows.Controls.ListBox)(target));
            return;
            case 8:
            this.btn_builder = ((System.Windows.Controls.Button)(target));
            
            #line 58 "..\..\ChannelTool.xaml"
            this.btn_builder.Click += new System.Windows.RoutedEventHandler(this.btn_builder_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.groupBox1 = ((System.Windows.Controls.GroupBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
