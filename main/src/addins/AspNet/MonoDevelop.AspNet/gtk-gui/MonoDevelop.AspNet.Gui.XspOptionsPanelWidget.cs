
// This file has been generated by the GUI designer. Do not modify.
namespace MonoDevelop.AspNet.Gui
{
	public partial class XspOptionsPanelWidget
	{
		private global::Gtk.VBox vbox1;

		private global::Gtk.Label label1;

		private global::Gtk.HBox hbox2;

		private global::Gtk.Label label4;

		private global::Gtk.VBox vbox2;

		private global::Gtk.Table table2;

		private global::Gtk.Entry ipAddress;

		private global::Gtk.Label label7;

		private global::Gtk.Label label8;

		private global::Gtk.SpinButton portNumber;

		private global::Gtk.CheckButton verboseCheck;

		private global::Gtk.Label label2;

		private global::Gtk.HBox hbox3;

		private global::Gtk.Label label5;

		private global::Gtk.Table table3;

		private global::Gtk.Label label10;

		private global::Gtk.Label label9;

		private global::Gtk.ComboBox sslMode;

		private global::Gtk.ComboBox sslProtocol;

		private global::Gtk.Label label3;

		private global::Gtk.HBox hbox4;

		private global::Gtk.Label label6;

		private global::Gtk.Table table4;

		private global::MonoDevelop.Components.FileEntry certLocation;

		private global::Gtk.HBox hbox5;

		private global::Gtk.ComboBox keyType;

		private global::Gtk.HBox hbox6;

		private global::Gtk.ComboBox passwordOptions;

		private global::Gtk.Entry passwordEntry;

		private global::MonoDevelop.Components.FileEntry keyLocation;

		private global::Gtk.Label label11;

		private global::Gtk.Label label12;

		private global::Gtk.Label label13;

		private global::Gtk.Label label14;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget MonoDevelop.AspNet.Gui.XspOptionsPanelWidget
			global::Stetic.BinContainer.Attach (this);
			this.Name = "MonoDevelop.AspNet.Gui.XspOptionsPanelWidget";
			// Container child MonoDevelop.AspNet.Gui.XspOptionsPanelWidget.Gtk.Container+ContainerChild
			this.vbox1 = new global::Gtk.VBox ();
			this.vbox1.Name = "vbox1";
			this.vbox1.Spacing = 12;
			// Container child vbox1.Gtk.Box+BoxChild
			this.label1 = new global::Gtk.Label ();
			this.label1.Name = "label1";
			this.label1.Xalign = 0f;
			this.label1.LabelProp = global::MonoDevelop.Core.GettextCatalog.GetString ("<b>General Options</b>");
			this.label1.UseMarkup = true;
			this.vbox1.Add (this.label1);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.label1]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox2 = new global::Gtk.HBox ();
			this.hbox2.Name = "hbox2";
			// Container child hbox2.Gtk.Box+BoxChild
			this.label4 = new global::Gtk.Label ();
			this.label4.WidthRequest = 18;
			this.label4.Name = "label4";
			this.hbox2.Add (this.label4);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.label4]));
			w2.Position = 0;
			w2.Expand = false;
			w2.Fill = false;
			// Container child hbox2.Gtk.Box+BoxChild
			this.vbox2 = new global::Gtk.VBox ();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			// Container child vbox2.Gtk.Box+BoxChild
			this.table2 = new global::Gtk.Table (((uint)(2)), ((uint)(2)), false);
			this.table2.Name = "table2";
			this.table2.RowSpacing = ((uint)(6));
			this.table2.ColumnSpacing = ((uint)(6));
			// Container child table2.Gtk.Table+TableChild
			this.ipAddress = new global::Gtk.Entry ();
			this.ipAddress.CanFocus = true;
			this.ipAddress.Name = "ipAddress";
			this.ipAddress.IsEditable = true;
			this.ipAddress.InvisibleChar = '●';
			this.table2.Add (this.ipAddress);
			global::Gtk.Table.TableChild w3 = ((global::Gtk.Table.TableChild)(this.table2[this.ipAddress]));
			w3.LeftAttach = ((uint)(1));
			w3.RightAttach = ((uint)(2));
			w3.XOptions = ((global::Gtk.AttachOptions)(4));
			w3.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.label7 = new global::Gtk.Label ();
			this.label7.Name = "label7";
			this.label7.Xalign = 0f;
			this.label7.LabelProp = global::MonoDevelop.Core.GettextCatalog.GetString ("Port number:");
			this.table2.Add (this.label7);
			global::Gtk.Table.TableChild w4 = ((global::Gtk.Table.TableChild)(this.table2[this.label7]));
			w4.TopAttach = ((uint)(1));
			w4.BottomAttach = ((uint)(2));
			w4.XOptions = ((global::Gtk.AttachOptions)(4));
			w4.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.label8 = new global::Gtk.Label ();
			this.label8.Name = "label8";
			this.label8.Xalign = 0f;
			this.label8.LabelProp = global::MonoDevelop.Core.GettextCatalog.GetString ("IP address:");
			this.table2.Add (this.label8);
			global::Gtk.Table.TableChild w5 = ((global::Gtk.Table.TableChild)(this.table2[this.label8]));
			w5.XOptions = ((global::Gtk.AttachOptions)(4));
			w5.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.portNumber = new global::Gtk.SpinButton (0, 32767, 1);
			this.portNumber.CanFocus = true;
			this.portNumber.Name = "portNumber";
			this.portNumber.Adjustment.PageIncrement = 10;
			this.portNumber.ClimbRate = 1;
			this.portNumber.Numeric = true;
			this.table2.Add (this.portNumber);
			global::Gtk.Table.TableChild w6 = ((global::Gtk.Table.TableChild)(this.table2[this.portNumber]));
			w6.TopAttach = ((uint)(1));
			w6.BottomAttach = ((uint)(2));
			w6.LeftAttach = ((uint)(1));
			w6.RightAttach = ((uint)(2));
			w6.XOptions = ((global::Gtk.AttachOptions)(4));
			w6.YOptions = ((global::Gtk.AttachOptions)(4));
			this.vbox2.Add (this.table2);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.table2]));
			w7.Position = 0;
			w7.Expand = false;
			w7.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.verboseCheck = new global::Gtk.CheckButton ();
			this.verboseCheck.CanFocus = true;
			this.verboseCheck.Name = "verboseCheck";
			this.verboseCheck.Label = global::MonoDevelop.Core.GettextCatalog.GetString ("Verbose console output");
			this.verboseCheck.DrawIndicator = true;
			this.verboseCheck.UseUnderline = true;
			this.vbox2.Add (this.verboseCheck);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.verboseCheck]));
			w8.Position = 1;
			w8.Expand = false;
			w8.Fill = false;
			this.hbox2.Add (this.vbox2);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.vbox2]));
			w9.Position = 1;
			w9.Expand = false;
			w9.Fill = false;
			this.vbox1.Add (this.hbox2);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox2]));
			w10.Position = 1;
			w10.Expand = false;
			w10.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.label2 = new global::Gtk.Label ();
			this.label2.Name = "label2";
			this.label2.Xalign = 0f;
			this.label2.LabelProp = global::MonoDevelop.Core.GettextCatalog.GetString ("<b>Security</b>");
			this.label2.UseMarkup = true;
			this.vbox1.Add (this.label2);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.label2]));
			w11.Position = 2;
			w11.Expand = false;
			w11.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox3 = new global::Gtk.HBox ();
			this.hbox3.Name = "hbox3";
			// Container child hbox3.Gtk.Box+BoxChild
			this.label5 = new global::Gtk.Label ();
			this.label5.WidthRequest = 18;
			this.label5.Name = "label5";
			this.hbox3.Add (this.label5);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.label5]));
			w12.Position = 0;
			w12.Expand = false;
			w12.Fill = false;
			// Container child hbox3.Gtk.Box+BoxChild
			this.table3 = new global::Gtk.Table (((uint)(2)), ((uint)(2)), false);
			this.table3.Name = "table3";
			this.table3.RowSpacing = ((uint)(6));
			this.table3.ColumnSpacing = ((uint)(6));
			// Container child table3.Gtk.Table+TableChild
			this.label10 = new global::Gtk.Label ();
			this.label10.Name = "label10";
			this.label10.Xalign = 0f;
			this.label10.LabelProp = global::MonoDevelop.Core.GettextCatalog.GetString ("SSL mode:");
			this.table3.Add (this.label10);
			global::Gtk.Table.TableChild w13 = ((global::Gtk.Table.TableChild)(this.table3[this.label10]));
			w13.XOptions = ((global::Gtk.AttachOptions)(4));
			w13.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.label9 = new global::Gtk.Label ();
			this.label9.Name = "label9";
			this.label9.Xalign = 0f;
			this.label9.LabelProp = global::MonoDevelop.Core.GettextCatalog.GetString ("SSL protocol:");
			this.table3.Add (this.label9);
			global::Gtk.Table.TableChild w14 = ((global::Gtk.Table.TableChild)(this.table3[this.label9]));
			w14.TopAttach = ((uint)(1));
			w14.BottomAttach = ((uint)(2));
			w14.XOptions = ((global::Gtk.AttachOptions)(4));
			w14.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.sslMode = global::Gtk.ComboBox.NewText ();
			this.sslMode.Name = "sslMode";
			this.table3.Add (this.sslMode);
			global::Gtk.Table.TableChild w15 = ((global::Gtk.Table.TableChild)(this.table3[this.sslMode]));
			w15.LeftAttach = ((uint)(1));
			w15.RightAttach = ((uint)(2));
			w15.XOptions = ((global::Gtk.AttachOptions)(4));
			w15.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.sslProtocol = global::Gtk.ComboBox.NewText ();
			this.sslProtocol.Name = "sslProtocol";
			this.table3.Add (this.sslProtocol);
			global::Gtk.Table.TableChild w16 = ((global::Gtk.Table.TableChild)(this.table3[this.sslProtocol]));
			w16.TopAttach = ((uint)(1));
			w16.BottomAttach = ((uint)(2));
			w16.LeftAttach = ((uint)(1));
			w16.RightAttach = ((uint)(2));
			w16.XOptions = ((global::Gtk.AttachOptions)(4));
			w16.YOptions = ((global::Gtk.AttachOptions)(4));
			this.hbox3.Add (this.table3);
			global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.table3]));
			w17.Position = 1;
			w17.Expand = false;
			w17.Fill = false;
			this.vbox1.Add (this.hbox3);
			global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox3]));
			w18.Position = 3;
			w18.Expand = false;
			w18.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.label3 = new global::Gtk.Label ();
			this.label3.Name = "label3";
			this.label3.Xalign = 0f;
			this.label3.LabelProp = global::MonoDevelop.Core.GettextCatalog.GetString ("<b>SSL Key</b>");
			this.label3.UseMarkup = true;
			this.vbox1.Add (this.label3);
			global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.label3]));
			w19.Position = 4;
			w19.Expand = false;
			w19.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox4 = new global::Gtk.HBox ();
			this.hbox4.Name = "hbox4";
			// Container child hbox4.Gtk.Box+BoxChild
			this.label6 = new global::Gtk.Label ();
			this.label6.WidthRequest = 18;
			this.label6.Name = "label6";
			this.hbox4.Add (this.label6);
			global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.label6]));
			w20.Position = 0;
			w20.Expand = false;
			w20.Fill = false;
			// Container child hbox4.Gtk.Box+BoxChild
			this.table4 = new global::Gtk.Table (((uint)(4)), ((uint)(2)), false);
			this.table4.Name = "table4";
			this.table4.RowSpacing = ((uint)(6));
			this.table4.ColumnSpacing = ((uint)(6));
			// Container child table4.Gtk.Table+TableChild
			this.certLocation = new global::MonoDevelop.Components.FileEntry ();
			this.certLocation.Name = "certLocation";
			this.table4.Add (this.certLocation);
			global::Gtk.Table.TableChild w21 = ((global::Gtk.Table.TableChild)(this.table4[this.certLocation]));
			w21.TopAttach = ((uint)(2));
			w21.BottomAttach = ((uint)(3));
			w21.LeftAttach = ((uint)(1));
			w21.RightAttach = ((uint)(2));
			w21.XOptions = ((global::Gtk.AttachOptions)(4));
			w21.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table4.Gtk.Table+TableChild
			this.hbox5 = new global::Gtk.HBox ();
			this.hbox5.Name = "hbox5";
			this.hbox5.Spacing = 6;
			// Container child hbox5.Gtk.Box+BoxChild
			this.keyType = global::Gtk.ComboBox.NewText ();
			this.keyType.Name = "keyType";
			this.hbox5.Add (this.keyType);
			global::Gtk.Box.BoxChild w22 = ((global::Gtk.Box.BoxChild)(this.hbox5[this.keyType]));
			w22.Position = 0;
			w22.Expand = false;
			w22.Fill = false;
			this.table4.Add (this.hbox5);
			global::Gtk.Table.TableChild w23 = ((global::Gtk.Table.TableChild)(this.table4[this.hbox5]));
			w23.LeftAttach = ((uint)(1));
			w23.RightAttach = ((uint)(2));
			w23.XOptions = ((global::Gtk.AttachOptions)(4));
			w23.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table4.Gtk.Table+TableChild
			this.hbox6 = new global::Gtk.HBox ();
			this.hbox6.Name = "hbox6";
			this.hbox6.Spacing = 6;
			// Container child hbox6.Gtk.Box+BoxChild
			this.passwordOptions = global::Gtk.ComboBox.NewText ();
			this.passwordOptions.Name = "passwordOptions";
			this.hbox6.Add (this.passwordOptions);
			global::Gtk.Box.BoxChild w24 = ((global::Gtk.Box.BoxChild)(this.hbox6[this.passwordOptions]));
			w24.Position = 0;
			w24.Expand = false;
			w24.Fill = false;
			// Container child hbox6.Gtk.Box+BoxChild
			this.passwordEntry = new global::Gtk.Entry ();
			this.passwordEntry.CanFocus = true;
			this.passwordEntry.Name = "passwordEntry";
			this.passwordEntry.IsEditable = true;
			this.passwordEntry.InvisibleChar = '●';
			this.hbox6.Add (this.passwordEntry);
			global::Gtk.Box.BoxChild w25 = ((global::Gtk.Box.BoxChild)(this.hbox6[this.passwordEntry]));
			w25.Position = 1;
			this.table4.Add (this.hbox6);
			global::Gtk.Table.TableChild w26 = ((global::Gtk.Table.TableChild)(this.table4[this.hbox6]));
			w26.TopAttach = ((uint)(3));
			w26.BottomAttach = ((uint)(4));
			w26.LeftAttach = ((uint)(1));
			w26.RightAttach = ((uint)(2));
			w26.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table4.Gtk.Table+TableChild
			this.keyLocation = new global::MonoDevelop.Components.FileEntry ();
			this.keyLocation.Name = "keyLocation";
			this.table4.Add (this.keyLocation);
			global::Gtk.Table.TableChild w27 = ((global::Gtk.Table.TableChild)(this.table4[this.keyLocation]));
			w27.TopAttach = ((uint)(1));
			w27.BottomAttach = ((uint)(2));
			w27.LeftAttach = ((uint)(1));
			w27.RightAttach = ((uint)(2));
			w27.XOptions = ((global::Gtk.AttachOptions)(4));
			w27.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table4.Gtk.Table+TableChild
			this.label11 = new global::Gtk.Label ();
			this.label11.Name = "label11";
			this.label11.Xalign = 0f;
			this.label11.LabelProp = global::MonoDevelop.Core.GettextCatalog.GetString ("Key type:");
			this.table4.Add (this.label11);
			global::Gtk.Table.TableChild w28 = ((global::Gtk.Table.TableChild)(this.table4[this.label11]));
			w28.XOptions = ((global::Gtk.AttachOptions)(4));
			w28.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table4.Gtk.Table+TableChild
			this.label12 = new global::Gtk.Label ();
			this.label12.Name = "label12";
			this.label12.Xalign = 0f;
			this.label12.LabelProp = global::MonoDevelop.Core.GettextCatalog.GetString ("Key location:");
			this.table4.Add (this.label12);
			global::Gtk.Table.TableChild w29 = ((global::Gtk.Table.TableChild)(this.table4[this.label12]));
			w29.TopAttach = ((uint)(1));
			w29.BottomAttach = ((uint)(2));
			w29.XOptions = ((global::Gtk.AttachOptions)(4));
			w29.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table4.Gtk.Table+TableChild
			this.label13 = new global::Gtk.Label ();
			this.label13.Name = "label13";
			this.label13.Xalign = 0f;
			this.label13.LabelProp = global::MonoDevelop.Core.GettextCatalog.GetString ("Certificate location:");
			this.table4.Add (this.label13);
			global::Gtk.Table.TableChild w30 = ((global::Gtk.Table.TableChild)(this.table4[this.label13]));
			w30.TopAttach = ((uint)(2));
			w30.BottomAttach = ((uint)(3));
			w30.XOptions = ((global::Gtk.AttachOptions)(4));
			w30.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table4.Gtk.Table+TableChild
			this.label14 = new global::Gtk.Label ();
			this.label14.Name = "label14";
			this.label14.Xalign = 0f;
			this.label14.LabelProp = global::MonoDevelop.Core.GettextCatalog.GetString ("Password:");
			this.table4.Add (this.label14);
			global::Gtk.Table.TableChild w31 = ((global::Gtk.Table.TableChild)(this.table4[this.label14]));
			w31.TopAttach = ((uint)(3));
			w31.BottomAttach = ((uint)(4));
			w31.XOptions = ((global::Gtk.AttachOptions)(4));
			w31.YOptions = ((global::Gtk.AttachOptions)(4));
			this.hbox4.Add (this.table4);
			global::Gtk.Box.BoxChild w32 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.table4]));
			w32.Position = 1;
			this.vbox1.Add (this.hbox4);
			global::Gtk.Box.BoxChild w33 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox4]));
			w33.Position = 5;
			w33.Expand = false;
			w33.Fill = false;
			this.Add (this.vbox1);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Show ();
			this.sslProtocol.Changed += new global::System.EventHandler (this.updateSensitivity);
			this.sslMode.Changed += new global::System.EventHandler (this.updateSensitivity);
			this.passwordOptions.Changed += new global::System.EventHandler (this.updateSensitivity);
			this.keyType.Changed += new global::System.EventHandler (this.updateSensitivity);
		}
	}
}
