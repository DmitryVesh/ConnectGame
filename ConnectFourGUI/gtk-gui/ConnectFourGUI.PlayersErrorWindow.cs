
// This file has been generated by the GUI designer. Do not modify.
namespace ConnectFourGUI
{
	public partial class PlayersErrorWindow
	{
		private global::Gtk.VBox vbox17;

		private global::Gtk.Alignment alignment9;

		private global::Gtk.Label errorMessageLbl;

		private global::Gtk.VBox vbox20;

		private global::Gtk.HBox hbox16;

		private global::Gtk.Alignment alignment13;

		private global::Gtk.Button okBtn;

		private global::Gtk.Alignment alignment11;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget ConnectFourGUI.PlayersErrorWindow
			this.Name = "ConnectFourGUI.PlayersErrorWindow";
			this.Title = global::Mono.Unix.Catalog.GetString("Players Error");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			this.Resizable = false;
			this.AllowGrow = false;
			// Container child ConnectFourGUI.PlayersErrorWindow.Gtk.Container+ContainerChild
			this.vbox17 = new global::Gtk.VBox();
			this.vbox17.Name = "vbox17";
			this.vbox17.Spacing = 6;
			// Container child vbox17.Gtk.Box+BoxChild
			this.alignment9 = new global::Gtk.Alignment(0.5F, 0.5F, 1F, 1F);
			this.alignment9.Name = "alignment9";
			this.vbox17.Add(this.alignment9);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox17[this.alignment9]));
			w1.Position = 0;
			// Container child vbox17.Gtk.Box+BoxChild
			this.errorMessageLbl = new global::Gtk.Label();
			this.errorMessageLbl.Name = "errorMessageLbl";
			this.errorMessageLbl.LabelProp = global::Mono.Unix.Catalog.GetString("error message");
			this.errorMessageLbl.Wrap = true;
			this.vbox17.Add(this.errorMessageLbl);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox17[this.errorMessageLbl]));
			w2.Position = 1;
			w2.Expand = false;
			w2.Fill = false;
			// Container child vbox17.Gtk.Box+BoxChild
			this.vbox20 = new global::Gtk.VBox();
			this.vbox20.Name = "vbox20";
			this.vbox20.Spacing = 6;
			// Container child vbox20.Gtk.Box+BoxChild
			this.hbox16 = new global::Gtk.HBox();
			this.hbox16.Name = "hbox16";
			this.hbox16.Spacing = 6;
			// Container child hbox16.Gtk.Box+BoxChild
			this.alignment13 = new global::Gtk.Alignment(0.5F, 0.5F, 1F, 1F);
			this.alignment13.Name = "alignment13";
			this.hbox16.Add(this.alignment13);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox16[this.alignment13]));
			w3.Position = 0;
			// Container child hbox16.Gtk.Box+BoxChild
			this.okBtn = new global::Gtk.Button();
			this.okBtn.WidthRequest = 50;
			this.okBtn.HeightRequest = 30;
			this.okBtn.CanFocus = true;
			this.okBtn.Name = "okBtn";
			this.okBtn.UseUnderline = true;
			this.okBtn.Label = global::Mono.Unix.Catalog.GetString("OK");
			this.hbox16.Add(this.okBtn);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox16[this.okBtn]));
			w4.Position = 1;
			w4.Expand = false;
			w4.Fill = false;
			this.vbox20.Add(this.hbox16);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox20[this.hbox16]));
			w5.Position = 0;
			w5.Expand = false;
			w5.Fill = false;
			// Container child vbox20.Gtk.Box+BoxChild
			this.alignment11 = new global::Gtk.Alignment(0.5F, 0.5F, 1F, 1F);
			this.alignment11.Name = "alignment11";
			this.vbox20.Add(this.alignment11);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox20[this.alignment11]));
			w6.Position = 1;
			this.vbox17.Add(this.vbox20);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.vbox17[this.vbox20]));
			w7.Position = 2;
			this.Add(this.vbox17);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.DefaultWidth = 381;
			this.DefaultHeight = 118;
			this.Show();
			this.okBtn.Clicked += new global::System.EventHandler(this.OnOkBtnClicked);
		}
	}
}
