﻿#pragma checksum "..\..\MainWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5BE0EDBD72FEB793347C5ABE914DD5E50A52B163"
//------------------------------------------------------------------------------
// <auto-generated>
//     Tento kód byl generován nástrojem.
//     Verze modulu runtime:4.0.30319.42000
//
//     Změny tohoto souboru mohou způsobit nesprávné chování a budou ztraceny,
//     dojde-li k novému generování kódu.
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
using WpfApp1;


namespace WpfApp1 {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid grid;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem horni;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem dolni;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem log;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem konec;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox vysledky;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid grid2;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button vypocti;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rad_f;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rad_R;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rad_C;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfApp1;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MainWindow.xaml"
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
            this.grid = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.horni = ((System.Windows.Controls.MenuItem)(target));
            
            #line 14 "..\..\MainWindow.xaml"
            this.horni.Click += new System.Windows.RoutedEventHandler(this.horni_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.dolni = ((System.Windows.Controls.MenuItem)(target));
            
            #line 15 "..\..\MainWindow.xaml"
            this.dolni.Click += new System.Windows.RoutedEventHandler(this.dolni_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.log = ((System.Windows.Controls.MenuItem)(target));
            
            #line 18 "..\..\MainWindow.xaml"
            this.log.Click += new System.Windows.RoutedEventHandler(this.log_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.konec = ((System.Windows.Controls.MenuItem)(target));
            
            #line 20 "..\..\MainWindow.xaml"
            this.konec.Click += new System.Windows.RoutedEventHandler(this.exit_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.vysledky = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.grid2 = ((System.Windows.Controls.Grid)(target));
            return;
            case 8:
            this.vypocti = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\MainWindow.xaml"
            this.vypocti.Click += new System.Windows.RoutedEventHandler(this.vypocti_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.rad_f = ((System.Windows.Controls.RadioButton)(target));
            
            #line 29 "..\..\MainWindow.xaml"
            this.rad_f.Checked += new System.Windows.RoutedEventHandler(this.RadioButton_Checked);
            
            #line default
            #line hidden
            return;
            case 10:
            this.rad_R = ((System.Windows.Controls.RadioButton)(target));
            
            #line 30 "..\..\MainWindow.xaml"
            this.rad_R.Checked += new System.Windows.RoutedEventHandler(this.RadioButton_Checked);
            
            #line default
            #line hidden
            return;
            case 11:
            this.rad_C = ((System.Windows.Controls.RadioButton)(target));
            
            #line 31 "..\..\MainWindow.xaml"
            this.rad_C.Checked += new System.Windows.RoutedEventHandler(this.RadioButton_Checked);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

