// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.1433
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace Example_StandardControls.Screens.iPhone.DatePicker {
	
	
	// Base type probably should be MonoTouch.UIKit.UIViewController or subclass
	[MonoTouch.Foundation.Register("DatePicker_iPhone")]
	public partial class DatePicker_iPhone {
		
		private MonoTouch.UIKit.UIView __mt_view;
		
		private MonoTouch.UIKit.UIButton __mt_btnChooseDate;
		
		private MonoTouch.UIKit.UILabel __mt_lblDate;
		
		#pragma warning disable 0169
		[MonoTouch.Foundation.Connect("view")]
		private MonoTouch.UIKit.UIView view {
			get {
				this.__mt_view = ((MonoTouch.UIKit.UIView)(this.GetNativeField("view")));
				return this.__mt_view;
			}
			set {
				this.__mt_view = value;
				this.SetNativeField("view", value);
			}
		}
		
		[MonoTouch.Foundation.Connect("btnChooseDate")]
		private MonoTouch.UIKit.UIButton btnChooseDate {
			get {
				this.__mt_btnChooseDate = ((MonoTouch.UIKit.UIButton)(this.GetNativeField("btnChooseDate")));
				return this.__mt_btnChooseDate;
			}
			set {
				this.__mt_btnChooseDate = value;
				this.SetNativeField("btnChooseDate", value);
			}
		}
		
		[MonoTouch.Foundation.Connect("lblDate")]
		private MonoTouch.UIKit.UILabel lblDate {
			get {
				this.__mt_lblDate = ((MonoTouch.UIKit.UILabel)(this.GetNativeField("lblDate")));
				return this.__mt_lblDate;
			}
			set {
				this.__mt_lblDate = value;
				this.SetNativeField("lblDate", value);
			}
		}
	}
}