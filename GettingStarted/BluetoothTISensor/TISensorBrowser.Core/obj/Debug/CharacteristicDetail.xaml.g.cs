// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 4.0.30319.17020
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace TISensorBrowser {
    using System;
    using Xamarin.Forms;
    using Xamarin.Forms.Xaml;
    
    
    public partial class CharacteristicDetail : ContentPage {
        
        private Label Name;
        
        private Label ID;
        
        private Label RawValue;
        
        private Label StringValue;
        
        private Label SensorValue;
        
        private void InitializeComponent() {
            this.LoadFromXaml(typeof(CharacteristicDetail));
            Name = this.FindByName <Label>("Name");
            ID = this.FindByName <Label>("ID");
            RawValue = this.FindByName <Label>("RawValue");
            StringValue = this.FindByName <Label>("StringValue");
            SensorValue = this.FindByName <Label>("SensorValue");
        }
    }
}
