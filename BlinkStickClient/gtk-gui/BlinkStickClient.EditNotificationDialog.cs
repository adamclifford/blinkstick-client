
// This file has been generated by the GUI designer. Do not modify.
namespace BlinkStickClient
{
	public partial class EditNotificationDialog
	{
		private global::Gtk.VBox vbox3;
		
		private global::Gtk.Frame frame1;
		
		private global::Gtk.Alignment GtkAlignment2;
		
		private global::Gtk.Table table2;
		
		private global::Gtk.Button buttonEditPatterns;
		
		private global::Gtk.CheckButton checkbuttonEnabled;
		
		private global::Gtk.ComboBox comboboxPattern;
		
		private global::BlinkStickClient.DeviceComboboxWidget deviceComboboxWidget;
		
		private global::Gtk.Entry entryName;
		
		private global::Gtk.HBox hbox1;
		
		private global::Gtk.SpinButton spinbuttonLedsFrom;
		
		private global::Gtk.Label labelLedsTo;
		
		private global::Gtk.SpinButton spinbuttonLedsTo;
		
		private global::Gtk.Label label3;
		
		private global::Gtk.Label label4;
		
		private global::Gtk.Label labelLeds;
		
		private global::Gtk.Label labelPattern;
		
		private global::Gtk.Label GtkLabel2;
		
		private global::Gtk.Button buttonCancel;
		
		private global::Gtk.Button buttonOk;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget BlinkStickClient.EditNotificationDialog
			this.Name = "BlinkStickClient.EditNotificationDialog";
			this.Title = global::Mono.Unix.Catalog.GetString ("Edit Notification");
			this.Resizable = false;
			this.SkipPagerHint = true;
			this.SkipTaskbarHint = true;
			// Internal child BlinkStickClient.EditNotificationDialog.VBox
			global::Gtk.VBox w1 = this.VBox;
			w1.Name = "dialog1_VBox";
			w1.BorderWidth = ((uint)(2));
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.vbox3 = new global::Gtk.VBox ();
			this.vbox3.Name = "vbox3";
			this.vbox3.Spacing = 6;
			// Container child vbox3.Gtk.Box+BoxChild
			this.frame1 = new global::Gtk.Frame ();
			this.frame1.Name = "frame1";
			this.frame1.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child frame1.Gtk.Container+ContainerChild
			this.GtkAlignment2 = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
			this.GtkAlignment2.Name = "GtkAlignment2";
			this.GtkAlignment2.LeftPadding = ((uint)(12));
			// Container child GtkAlignment2.Gtk.Container+ContainerChild
			this.table2 = new global::Gtk.Table (((uint)(5)), ((uint)(3)), false);
			this.table2.Name = "table2";
			this.table2.RowSpacing = ((uint)(6));
			this.table2.ColumnSpacing = ((uint)(6));
			// Container child table2.Gtk.Table+TableChild
			this.buttonEditPatterns = new global::Gtk.Button ();
			this.buttonEditPatterns.CanFocus = true;
			this.buttonEditPatterns.Name = "buttonEditPatterns";
			this.buttonEditPatterns.UseUnderline = true;
			global::Gtk.Image w2 = new global::Gtk.Image ();
			w2.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-edit", global::Gtk.IconSize.Menu);
			this.buttonEditPatterns.Image = w2;
			this.table2.Add (this.buttonEditPatterns);
			global::Gtk.Table.TableChild w3 = ((global::Gtk.Table.TableChild)(this.table2 [this.buttonEditPatterns]));
			w3.TopAttach = ((uint)(3));
			w3.BottomAttach = ((uint)(4));
			w3.LeftAttach = ((uint)(2));
			w3.RightAttach = ((uint)(3));
			w3.XOptions = ((global::Gtk.AttachOptions)(4));
			w3.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.checkbuttonEnabled = new global::Gtk.CheckButton ();
			this.checkbuttonEnabled.CanFocus = true;
			this.checkbuttonEnabled.Name = "checkbuttonEnabled";
			this.checkbuttonEnabled.Label = global::Mono.Unix.Catalog.GetString ("Enabled");
			this.checkbuttonEnabled.DrawIndicator = true;
			this.checkbuttonEnabled.UseUnderline = true;
			this.table2.Add (this.checkbuttonEnabled);
			global::Gtk.Table.TableChild w4 = ((global::Gtk.Table.TableChild)(this.table2 [this.checkbuttonEnabled]));
			w4.LeftAttach = ((uint)(1));
			w4.RightAttach = ((uint)(2));
			w4.XOptions = ((global::Gtk.AttachOptions)(4));
			w4.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.comboboxPattern = new global::Gtk.ComboBox ();
			this.comboboxPattern.Name = "comboboxPattern";
			this.table2.Add (this.comboboxPattern);
			global::Gtk.Table.TableChild w5 = ((global::Gtk.Table.TableChild)(this.table2 [this.comboboxPattern]));
			w5.TopAttach = ((uint)(3));
			w5.BottomAttach = ((uint)(4));
			w5.LeftAttach = ((uint)(1));
			w5.RightAttach = ((uint)(2));
			w5.XOptions = ((global::Gtk.AttachOptions)(4));
			w5.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.deviceComboboxWidget = new global::BlinkStickClient.DeviceComboboxWidget ();
			this.deviceComboboxWidget.Events = ((global::Gdk.EventMask)(256));
			this.deviceComboboxWidget.Name = "deviceComboboxWidget";
			this.deviceComboboxWidget.AutoSelectDevice = false;
			this.table2.Add (this.deviceComboboxWidget);
			global::Gtk.Table.TableChild w6 = ((global::Gtk.Table.TableChild)(this.table2 [this.deviceComboboxWidget]));
			w6.TopAttach = ((uint)(2));
			w6.BottomAttach = ((uint)(3));
			w6.LeftAttach = ((uint)(1));
			w6.RightAttach = ((uint)(2));
			w6.XOptions = ((global::Gtk.AttachOptions)(4));
			w6.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.entryName = new global::Gtk.Entry ();
			this.entryName.CanFocus = true;
			this.entryName.Name = "entryName";
			this.entryName.IsEditable = true;
			this.entryName.InvisibleChar = '●';
			this.table2.Add (this.entryName);
			global::Gtk.Table.TableChild w7 = ((global::Gtk.Table.TableChild)(this.table2 [this.entryName]));
			w7.TopAttach = ((uint)(1));
			w7.BottomAttach = ((uint)(2));
			w7.LeftAttach = ((uint)(1));
			w7.RightAttach = ((uint)(2));
			w7.XOptions = ((global::Gtk.AttachOptions)(4));
			w7.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.hbox1 = new global::Gtk.HBox ();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.spinbuttonLedsFrom = new global::Gtk.SpinButton (0D, 63D, 1D);
			this.spinbuttonLedsFrom.CanFocus = true;
			this.spinbuttonLedsFrom.Name = "spinbuttonLedsFrom";
			this.spinbuttonLedsFrom.Adjustment.PageIncrement = 10D;
			this.spinbuttonLedsFrom.ClimbRate = 1D;
			this.spinbuttonLedsFrom.Numeric = true;
			this.hbox1.Add (this.spinbuttonLedsFrom);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.spinbuttonLedsFrom]));
			w8.Position = 0;
			w8.Expand = false;
			w8.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.labelLedsTo = new global::Gtk.Label ();
			this.labelLedsTo.Name = "labelLedsTo";
			this.labelLedsTo.LabelProp = global::Mono.Unix.Catalog.GetString ("to");
			this.hbox1.Add (this.labelLedsTo);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.labelLedsTo]));
			w9.Position = 1;
			w9.Expand = false;
			w9.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.spinbuttonLedsTo = new global::Gtk.SpinButton (0D, 63D, 1D);
			this.spinbuttonLedsTo.CanFocus = true;
			this.spinbuttonLedsTo.Name = "spinbuttonLedsTo";
			this.spinbuttonLedsTo.Adjustment.PageIncrement = 10D;
			this.spinbuttonLedsTo.ClimbRate = 1D;
			this.spinbuttonLedsTo.Numeric = true;
			this.hbox1.Add (this.spinbuttonLedsTo);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.spinbuttonLedsTo]));
			w10.Position = 2;
			w10.Expand = false;
			w10.Fill = false;
			this.table2.Add (this.hbox1);
			global::Gtk.Table.TableChild w11 = ((global::Gtk.Table.TableChild)(this.table2 [this.hbox1]));
			w11.TopAttach = ((uint)(4));
			w11.BottomAttach = ((uint)(5));
			w11.LeftAttach = ((uint)(1));
			w11.RightAttach = ((uint)(2));
			w11.XOptions = ((global::Gtk.AttachOptions)(4));
			w11.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.label3 = new global::Gtk.Label ();
			this.label3.Name = "label3";
			this.label3.Xalign = 1F;
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString ("Name:");
			this.table2.Add (this.label3);
			global::Gtk.Table.TableChild w12 = ((global::Gtk.Table.TableChild)(this.table2 [this.label3]));
			w12.TopAttach = ((uint)(1));
			w12.BottomAttach = ((uint)(2));
			w12.XOptions = ((global::Gtk.AttachOptions)(4));
			w12.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.label4 = new global::Gtk.Label ();
			this.label4.Name = "label4";
			this.label4.Xalign = 1F;
			this.label4.LabelProp = global::Mono.Unix.Catalog.GetString ("BlinkStick:");
			this.table2.Add (this.label4);
			global::Gtk.Table.TableChild w13 = ((global::Gtk.Table.TableChild)(this.table2 [this.label4]));
			w13.TopAttach = ((uint)(2));
			w13.BottomAttach = ((uint)(3));
			w13.XOptions = ((global::Gtk.AttachOptions)(4));
			w13.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.labelLeds = new global::Gtk.Label ();
			this.labelLeds.Name = "labelLeds";
			this.labelLeds.Xalign = 1F;
			this.labelLeds.LabelProp = global::Mono.Unix.Catalog.GetString ("LEDs:");
			this.table2.Add (this.labelLeds);
			global::Gtk.Table.TableChild w14 = ((global::Gtk.Table.TableChild)(this.table2 [this.labelLeds]));
			w14.TopAttach = ((uint)(4));
			w14.BottomAttach = ((uint)(5));
			w14.XOptions = ((global::Gtk.AttachOptions)(4));
			w14.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.labelPattern = new global::Gtk.Label ();
			this.labelPattern.Name = "labelPattern";
			this.labelPattern.Xalign = 1F;
			this.labelPattern.LabelProp = global::Mono.Unix.Catalog.GetString ("Pattern:");
			this.table2.Add (this.labelPattern);
			global::Gtk.Table.TableChild w15 = ((global::Gtk.Table.TableChild)(this.table2 [this.labelPattern]));
			w15.TopAttach = ((uint)(3));
			w15.BottomAttach = ((uint)(4));
			w15.XOptions = ((global::Gtk.AttachOptions)(4));
			w15.YOptions = ((global::Gtk.AttachOptions)(4));
			this.GtkAlignment2.Add (this.table2);
			this.frame1.Add (this.GtkAlignment2);
			this.GtkLabel2 = new global::Gtk.Label ();
			this.GtkLabel2.Name = "GtkLabel2";
			this.GtkLabel2.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>General</b>");
			this.GtkLabel2.UseMarkup = true;
			this.frame1.LabelWidget = this.GtkLabel2;
			this.vbox3.Add (this.frame1);
			global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.frame1]));
			w18.Position = 0;
			w18.Expand = false;
			w18.Fill = false;
			w1.Add (this.vbox3);
			global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(w1 [this.vbox3]));
			w19.Position = 0;
			// Internal child BlinkStickClient.EditNotificationDialog.ActionArea
			global::Gtk.HButtonBox w20 = this.ActionArea;
			w20.Name = "dialog1_ActionArea";
			w20.Spacing = 10;
			w20.BorderWidth = ((uint)(5));
			w20.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(4));
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonCancel = new global::Gtk.Button ();
			this.buttonCancel.CanDefault = true;
			this.buttonCancel.CanFocus = true;
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.UseStock = true;
			this.buttonCancel.UseUnderline = true;
			this.buttonCancel.Label = "gtk-cancel";
			this.AddActionWidget (this.buttonCancel, -6);
			global::Gtk.ButtonBox.ButtonBoxChild w21 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w20 [this.buttonCancel]));
			w21.Expand = false;
			w21.Fill = false;
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonOk = new global::Gtk.Button ();
			this.buttonOk.CanDefault = true;
			this.buttonOk.CanFocus = true;
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.UseStock = true;
			this.buttonOk.UseUnderline = true;
			this.buttonOk.Label = "gtk-ok";
			w20.Add (this.buttonOk);
			global::Gtk.ButtonBox.ButtonBoxChild w22 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w20 [this.buttonOk]));
			w22.Position = 1;
			w22.Expand = false;
			w22.Fill = false;
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 309;
			this.DefaultHeight = 373;
			this.Show ();
			this.buttonEditPatterns.Clicked += new global::System.EventHandler (this.OnButtonEditPatternsClicked);
			this.buttonOk.Clicked += new global::System.EventHandler (this.OnButtonOkClicked);
		}
	}
}
