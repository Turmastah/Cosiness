﻿#pragma checksum "..\..\PersonalOrders.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "08DC14ADD6BFA390E239EB44D5564CE48687E8A2202535C7C31E684E67B14224"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using PC_Shop;
using PC_Shop.Commands;
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


namespace PC_Shop {
    
    
    /// <summary>
    /// PersonalOrders
    /// </summary>
    public partial class PersonalOrders : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 27 "..\..\PersonalOrders.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ToolBar ToolBar1;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\PersonalOrders.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Undo;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\PersonalOrders.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Add;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\PersonalOrders.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Edit;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\PersonalOrders.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Save;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\PersonalOrders.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Delete;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\PersonalOrders.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Refresh;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\PersonalOrders.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid orderGrid;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\PersonalOrders.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BackButton;
        
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
            System.Uri resourceLocater = new System.Uri("/PC_Shop;component/personalorders.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\PersonalOrders.xaml"
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
            this.ToolBar1 = ((System.Windows.Controls.ToolBar)(target));
            return;
            case 2:
            this.Undo = ((System.Windows.Controls.Button)(target));
            return;
            case 3:
            this.Add = ((System.Windows.Controls.Button)(target));
            return;
            case 4:
            this.Edit = ((System.Windows.Controls.Button)(target));
            return;
            case 5:
            this.Save = ((System.Windows.Controls.Button)(target));
            return;
            case 6:
            this.Delete = ((System.Windows.Controls.Button)(target));
            return;
            case 7:
            this.Refresh = ((System.Windows.Controls.Button)(target));
            return;
            case 8:
            this.orderGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 9:
            this.BackButton = ((System.Windows.Controls.Button)(target));
            
            #line 67 "..\..\PersonalOrders.xaml"
            this.BackButton.Click += new System.Windows.RoutedEventHandler(this.BackButton_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 70 "..\..\PersonalOrders.xaml"
            ((System.Windows.Input.CommandBinding)(target)).Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.DeleteCommandBinding_Executed);
            
            #line default
            #line hidden
            
            #line 70 "..\..\PersonalOrders.xaml"
            ((System.Windows.Input.CommandBinding)(target)).CanExecute += new System.Windows.Input.CanExecuteRoutedEventHandler(this.DeleteCommandBinding_CanExecute);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 71 "..\..\PersonalOrders.xaml"
            ((System.Windows.Input.CommandBinding)(target)).Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.EditCommandBinding_Executed);
            
            #line default
            #line hidden
            
            #line 71 "..\..\PersonalOrders.xaml"
            ((System.Windows.Input.CommandBinding)(target)).CanExecute += new System.Windows.Input.CanExecuteRoutedEventHandler(this.EditCommandBinding_CanExecute);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 72 "..\..\PersonalOrders.xaml"
            ((System.Windows.Input.CommandBinding)(target)).CanExecute += new System.Windows.Input.CanExecuteRoutedEventHandler(this.SaveCommandBinding_CanExecute);
            
            #line default
            #line hidden
            
            #line 72 "..\..\PersonalOrders.xaml"
            ((System.Windows.Input.CommandBinding)(target)).Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.SaveCommandBinding_Executed);
            
            #line default
            #line hidden
            return;
            case 13:
            
            #line 73 "..\..\PersonalOrders.xaml"
            ((System.Windows.Input.CommandBinding)(target)).CanExecute += new System.Windows.Input.CanExecuteRoutedEventHandler(this.UndoCommandBinding_CanExecute);
            
            #line default
            #line hidden
            
            #line 73 "..\..\PersonalOrders.xaml"
            ((System.Windows.Input.CommandBinding)(target)).Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.UndoCommandBinding_Executed);
            
            #line default
            #line hidden
            return;
            case 14:
            
            #line 74 "..\..\PersonalOrders.xaml"
            ((System.Windows.Input.CommandBinding)(target)).CanExecute += new System.Windows.Input.CanExecuteRoutedEventHandler(this.NewCommandBinding_CanExecute);
            
            #line default
            #line hidden
            
            #line 74 "..\..\PersonalOrders.xaml"
            ((System.Windows.Input.CommandBinding)(target)).Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.NewCommandBinding_Executed);
            
            #line default
            #line hidden
            return;
            case 15:
            
            #line 75 "..\..\PersonalOrders.xaml"
            ((System.Windows.Input.CommandBinding)(target)).CanExecute += new System.Windows.Input.CanExecuteRoutedEventHandler(this.RefreshCommandBinding_CanExecute);
            
            #line default
            #line hidden
            
            #line 75 "..\..\PersonalOrders.xaml"
            ((System.Windows.Input.CommandBinding)(target)).Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.RefreshCommandBinding_Executed);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

