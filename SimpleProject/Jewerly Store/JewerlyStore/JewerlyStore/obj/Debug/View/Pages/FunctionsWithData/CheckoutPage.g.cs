#pragma checksum "..\..\..\..\..\View\Pages\FunctionsWithData\CheckoutPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "C13550F82DBC69B0B983326E20ED2E7AE89B0A41820637845F57672D50449887"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using JewerlyStore.View.Pages.FunctionsWithData;
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


namespace JewerlyStore.View.Pages.FunctionsWithData {
    
    
    /// <summary>
    /// CheckoutPage
    /// </summary>
    public partial class CheckoutPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 20 "..\..\..\..\..\View\Pages\FunctionsWithData\CheckoutPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txbLastName;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\..\..\View\Pages\FunctionsWithData\CheckoutPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txbFirstName;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\..\..\View\Pages\FunctionsWithData\CheckoutPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txbSecondName;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\..\..\View\Pages\FunctionsWithData\CheckoutPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txbPhone;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\..\..\View\Pages\FunctionsWithData\CheckoutPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSave;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\..\..\View\Pages\FunctionsWithData\CheckoutPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCancel;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\..\..\..\View\Pages\FunctionsWithData\CheckoutPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnNext;
        
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
            System.Uri resourceLocater = new System.Uri("/JewerlyStore;component/view/pages/functionswithdata/checkoutpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\View\Pages\FunctionsWithData\CheckoutPage.xaml"
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
            this.txbLastName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.txbFirstName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.txbSecondName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.txbPhone = ((System.Windows.Controls.TextBox)(target));
            
            #line 30 "..\..\..\..\..\View\Pages\FunctionsWithData\CheckoutPage.xaml"
            this.txbPhone.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.txbPhone_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnSave = ((System.Windows.Controls.Button)(target));
            
            #line 46 "..\..\..\..\..\View\Pages\FunctionsWithData\CheckoutPage.xaml"
            this.btnSave.Click += new System.Windows.RoutedEventHandler(this.btnSave_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnCancel = ((System.Windows.Controls.Button)(target));
            
            #line 56 "..\..\..\..\..\View\Pages\FunctionsWithData\CheckoutPage.xaml"
            this.btnCancel.Click += new System.Windows.RoutedEventHandler(this.btnCancel_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btnNext = ((System.Windows.Controls.Button)(target));
            
            #line 66 "..\..\..\..\..\View\Pages\FunctionsWithData\CheckoutPage.xaml"
            this.btnNext.Click += new System.Windows.RoutedEventHandler(this.btnNext_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

