
// This file has been generated by the GUI designer. Do not modify.
namespace ConnectFourGUI
{
	public partial class NewGameWindow
	{
		private global::Gtk.VBox vbox10;

		private global::Gtk.VBox vbox13;

		private global::Gtk.Alignment alignment5;

		private global::Gtk.HBox hbox2;

		private global::Gtk.Label numRowsLbl;

		private global::Gtk.SpinButton numRowsSpinBtn;

		private global::Gtk.HBox hbox4;

		private global::Gtk.Label numColumnsLbl;

		private global::Gtk.SpinButton numColumnsSpinBtn;

		private global::Gtk.VBox vbox11;

		private global::Gtk.HBox hbox6;

		private global::Gtk.Label numCountersWinLbl;

		private global::Gtk.SpinButton numCountersWinSpinBtn;

		private global::Gtk.Alignment alignment7;

		private global::Gtk.HBox hbox8;

		private global::Gtk.Label numHumanPlayersLbl;

		private global::Gtk.SpinButton numHumanPlayersSpinBtn;

		private global::Gtk.VBox vbox15;

		private global::Gtk.HBox hbox10;

		private global::Gtk.Label numAILbl;

		private global::Gtk.SpinButton numAIPlayersSpinBtn;

		private global::Gtk.HBox hbox12;

		private global::Gtk.Label boolAIMoveWaitLbl;

		private global::Gtk.CheckButton AIMoveWaitButton;

		private global::Gtk.HBox hbox14;

		private global::Gtk.Alignment alignment10;

		private global::Gtk.Button cancelGameSettingsBtn;

		private global::Gtk.Button startGameBtn;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget ConnectFourGUI.NewGameWindow
			this.Name = "ConnectFourGUI.NewGameWindow";
			this.Title = global::Mono.Unix.Catalog.GetString("NewGameWindow");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Container child ConnectFourGUI.NewGameWindow.Gtk.Container+ContainerChild
			this.vbox10 = new global::Gtk.VBox();
			this.vbox10.Name = "vbox10";
			this.vbox10.Spacing = 6;
			// Container child vbox10.Gtk.Box+BoxChild
			this.vbox13 = new global::Gtk.VBox();
			this.vbox13.Name = "vbox13";
			this.vbox13.Spacing = 6;
			// Container child vbox13.Gtk.Box+BoxChild
			this.alignment5 = new global::Gtk.Alignment(0.5F, 0.5F, 1F, 1F);
			this.alignment5.Name = "alignment5";
			this.vbox13.Add(this.alignment5);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox13[this.alignment5]));
			w1.Position = 0;
			// Container child vbox13.Gtk.Box+BoxChild
			this.hbox2 = new global::Gtk.HBox();
			this.hbox2.Name = "hbox2";
			this.hbox2.Spacing = 6;
			// Container child hbox2.Gtk.Box+BoxChild
			this.numRowsLbl = new global::Gtk.Label();
			this.numRowsLbl.WidthRequest = 160;
			this.numRowsLbl.Name = "numRowsLbl";
			this.numRowsLbl.LabelProp = global::Mono.Unix.Catalog.GetString("Number of rows :");
			this.hbox2.Add(this.numRowsLbl);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.numRowsLbl]));
			w2.Position = 0;
			w2.Expand = false;
			w2.Fill = false;
			// Container child hbox2.Gtk.Box+BoxChild
			this.numRowsSpinBtn = new global::Gtk.SpinButton(6D, 20D, 1D);
			this.numRowsSpinBtn.CanFocus = true;
			this.numRowsSpinBtn.Name = "numRowsSpinBtn";
			this.numRowsSpinBtn.Adjustment.PageIncrement = 10D;
			this.numRowsSpinBtn.ClimbRate = 1D;
			this.numRowsSpinBtn.Numeric = true;
			this.numRowsSpinBtn.Value = 6D;
			this.hbox2.Add(this.numRowsSpinBtn);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.numRowsSpinBtn]));
			w3.Position = 1;
			w3.Expand = false;
			w3.Fill = false;
			this.vbox13.Add(this.hbox2);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox13[this.hbox2]));
			w4.Position = 1;
			w4.Expand = false;
			w4.Fill = false;
			// Container child vbox13.Gtk.Box+BoxChild
			this.hbox4 = new global::Gtk.HBox();
			this.hbox4.Name = "hbox4";
			this.hbox4.Spacing = 6;
			// Container child hbox4.Gtk.Box+BoxChild
			this.numColumnsLbl = new global::Gtk.Label();
			this.numColumnsLbl.WidthRequest = 160;
			this.numColumnsLbl.Name = "numColumnsLbl";
			this.numColumnsLbl.LabelProp = global::Mono.Unix.Catalog.GetString("Number of colums :");
			this.hbox4.Add(this.numColumnsLbl);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.numColumnsLbl]));
			w5.Position = 0;
			w5.Expand = false;
			w5.Fill = false;
			// Container child hbox4.Gtk.Box+BoxChild
			this.numColumnsSpinBtn = new global::Gtk.SpinButton(7D, 20D, 1D);
			this.numColumnsSpinBtn.CanFocus = true;
			this.numColumnsSpinBtn.Name = "numColumnsSpinBtn";
			this.numColumnsSpinBtn.Adjustment.PageIncrement = 10D;
			this.numColumnsSpinBtn.ClimbRate = 1D;
			this.numColumnsSpinBtn.Numeric = true;
			this.numColumnsSpinBtn.Value = 7D;
			this.hbox4.Add(this.numColumnsSpinBtn);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.numColumnsSpinBtn]));
			w6.Position = 1;
			w6.Expand = false;
			w6.Fill = false;
			this.vbox13.Add(this.hbox4);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.vbox13[this.hbox4]));
			w7.Position = 2;
			w7.Expand = false;
			w7.Fill = false;
			this.vbox10.Add(this.vbox13);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.vbox10[this.vbox13]));
			w8.Position = 0;
			// Container child vbox10.Gtk.Box+BoxChild
			this.vbox11 = new global::Gtk.VBox();
			this.vbox11.Name = "vbox11";
			this.vbox11.Spacing = 6;
			// Container child vbox11.Gtk.Box+BoxChild
			this.hbox6 = new global::Gtk.HBox();
			this.hbox6.Name = "hbox6";
			this.hbox6.Spacing = 6;
			// Container child hbox6.Gtk.Box+BoxChild
			this.numCountersWinLbl = new global::Gtk.Label();
			this.numCountersWinLbl.WidthRequest = 160;
			this.numCountersWinLbl.Name = "numCountersWinLbl";
			this.numCountersWinLbl.LabelProp = global::Mono.Unix.Catalog.GetString("Number counters to win :");
			this.hbox6.Add(this.numCountersWinLbl);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.hbox6[this.numCountersWinLbl]));
			w9.Position = 0;
			w9.Expand = false;
			w9.Fill = false;
			// Container child hbox6.Gtk.Box+BoxChild
			this.numCountersWinSpinBtn = new global::Gtk.SpinButton(4D, 100D, 1D);
			this.numCountersWinSpinBtn.CanFocus = true;
			this.numCountersWinSpinBtn.Name = "numCountersWinSpinBtn";
			this.numCountersWinSpinBtn.Adjustment.PageIncrement = 10D;
			this.numCountersWinSpinBtn.ClimbRate = 1D;
			this.numCountersWinSpinBtn.Numeric = true;
			this.numCountersWinSpinBtn.Value = 4D;
			this.hbox6.Add(this.numCountersWinSpinBtn);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.hbox6[this.numCountersWinSpinBtn]));
			w10.Position = 1;
			w10.Expand = false;
			w10.Fill = false;
			this.vbox11.Add(this.hbox6);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.vbox11[this.hbox6]));
			w11.Position = 0;
			w11.Expand = false;
			w11.Fill = false;
			// Container child vbox11.Gtk.Box+BoxChild
			this.alignment7 = new global::Gtk.Alignment(0.5F, 0.5F, 1F, 1F);
			this.alignment7.Name = "alignment7";
			this.vbox11.Add(this.alignment7);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.vbox11[this.alignment7]));
			w12.Position = 1;
			// Container child vbox11.Gtk.Box+BoxChild
			this.hbox8 = new global::Gtk.HBox();
			this.hbox8.Name = "hbox8";
			this.hbox8.Spacing = 6;
			// Container child hbox8.Gtk.Box+BoxChild
			this.numHumanPlayersLbl = new global::Gtk.Label();
			this.numHumanPlayersLbl.WidthRequest = 160;
			this.numHumanPlayersLbl.Name = "numHumanPlayersLbl";
			this.numHumanPlayersLbl.LabelProp = global::Mono.Unix.Catalog.GetString("Number of human players :");
			this.hbox8.Add(this.numHumanPlayersLbl);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.hbox8[this.numHumanPlayersLbl]));
			w13.Position = 0;
			w13.Expand = false;
			w13.Fill = false;
			// Container child hbox8.Gtk.Box+BoxChild
			this.numHumanPlayersSpinBtn = new global::Gtk.SpinButton(0D, 10D, 1D);
			this.numHumanPlayersSpinBtn.CanFocus = true;
			this.numHumanPlayersSpinBtn.Name = "numHumanPlayersSpinBtn";
			this.numHumanPlayersSpinBtn.Adjustment.PageIncrement = 10D;
			this.numHumanPlayersSpinBtn.ClimbRate = 1D;
			this.numHumanPlayersSpinBtn.Numeric = true;
			this.numHumanPlayersSpinBtn.Value = 1D;
			this.hbox8.Add(this.numHumanPlayersSpinBtn);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.hbox8[this.numHumanPlayersSpinBtn]));
			w14.Position = 1;
			w14.Expand = false;
			w14.Fill = false;
			this.vbox11.Add(this.hbox8);
			global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.vbox11[this.hbox8]));
			w15.Position = 2;
			w15.Expand = false;
			w15.Fill = false;
			this.vbox10.Add(this.vbox11);
			global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.vbox10[this.vbox11]));
			w16.Position = 1;
			// Container child vbox10.Gtk.Box+BoxChild
			this.vbox15 = new global::Gtk.VBox();
			this.vbox15.Name = "vbox15";
			this.vbox15.Spacing = 6;
			// Container child vbox15.Gtk.Box+BoxChild
			this.hbox10 = new global::Gtk.HBox();
			this.hbox10.Name = "hbox10";
			this.hbox10.Spacing = 6;
			// Container child hbox10.Gtk.Box+BoxChild
			this.numAILbl = new global::Gtk.Label();
			this.numAILbl.WidthRequest = 160;
			this.numAILbl.Name = "numAILbl";
			this.numAILbl.LabelProp = global::Mono.Unix.Catalog.GetString("Number of AI players :");
			this.hbox10.Add(this.numAILbl);
			global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.hbox10[this.numAILbl]));
			w17.Position = 0;
			w17.Expand = false;
			w17.Fill = false;
			// Container child hbox10.Gtk.Box+BoxChild
			this.numAIPlayersSpinBtn = new global::Gtk.SpinButton(0D, 10D, 1D);
			this.numAIPlayersSpinBtn.CanFocus = true;
			this.numAIPlayersSpinBtn.Name = "numAIPlayersSpinBtn";
			this.numAIPlayersSpinBtn.Adjustment.PageIncrement = 10D;
			this.numAIPlayersSpinBtn.ClimbRate = 1D;
			this.numAIPlayersSpinBtn.Numeric = true;
			this.numAIPlayersSpinBtn.Value = 1D;
			this.hbox10.Add(this.numAIPlayersSpinBtn);
			global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.hbox10[this.numAIPlayersSpinBtn]));
			w18.Position = 1;
			w18.Expand = false;
			w18.Fill = false;
			this.vbox15.Add(this.hbox10);
			global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.vbox15[this.hbox10]));
			w19.Position = 0;
			w19.Expand = false;
			w19.Fill = false;
			// Container child vbox15.Gtk.Box+BoxChild
			this.hbox12 = new global::Gtk.HBox();
			this.hbox12.Name = "hbox12";
			this.hbox12.Spacing = 6;
			// Container child hbox12.Gtk.Box+BoxChild
			this.boolAIMoveWaitLbl = new global::Gtk.Label();
			this.boolAIMoveWaitLbl.WidthRequest = 160;
			this.boolAIMoveWaitLbl.Name = "boolAIMoveWaitLbl";
			this.boolAIMoveWaitLbl.LabelProp = global::Mono.Unix.Catalog.GetString("Wait after AI moves :");
			this.hbox12.Add(this.boolAIMoveWaitLbl);
			global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(this.hbox12[this.boolAIMoveWaitLbl]));
			w20.Position = 0;
			w20.Expand = false;
			w20.Fill = false;
			// Container child hbox12.Gtk.Box+BoxChild
			this.AIMoveWaitButton = new global::Gtk.CheckButton();
			this.AIMoveWaitButton.WidthRequest = 0;
			this.AIMoveWaitButton.CanFocus = true;
			this.AIMoveWaitButton.Name = "AIMoveWaitButton";
			this.AIMoveWaitButton.Label = global::Mono.Unix.Catalog.GetString("Tick for yes");
			this.AIMoveWaitButton.Active = true;
			this.AIMoveWaitButton.DrawIndicator = true;
			this.AIMoveWaitButton.UseUnderline = true;
			this.hbox12.Add(this.AIMoveWaitButton);
			global::Gtk.Box.BoxChild w21 = ((global::Gtk.Box.BoxChild)(this.hbox12[this.AIMoveWaitButton]));
			w21.Position = 1;
			this.vbox15.Add(this.hbox12);
			global::Gtk.Box.BoxChild w22 = ((global::Gtk.Box.BoxChild)(this.vbox15[this.hbox12]));
			w22.Position = 1;
			w22.Expand = false;
			w22.Fill = false;
			// Container child vbox15.Gtk.Box+BoxChild
			this.hbox14 = new global::Gtk.HBox();
			this.hbox14.Name = "hbox14";
			this.hbox14.Spacing = 6;
			// Container child hbox14.Gtk.Box+BoxChild
			this.alignment10 = new global::Gtk.Alignment(0.5F, 0.5F, 1F, 1F);
			this.alignment10.Name = "alignment10";
			this.hbox14.Add(this.alignment10);
			global::Gtk.Box.BoxChild w23 = ((global::Gtk.Box.BoxChild)(this.hbox14[this.alignment10]));
			w23.Position = 0;
			// Container child hbox14.Gtk.Box+BoxChild
			this.cancelGameSettingsBtn = new global::Gtk.Button();
			this.cancelGameSettingsBtn.WidthRequest = 60;
			this.cancelGameSettingsBtn.HeightRequest = 35;
			this.cancelGameSettingsBtn.CanFocus = true;
			this.cancelGameSettingsBtn.Name = "cancelGameSettingsBtn";
			this.cancelGameSettingsBtn.UseUnderline = true;
			this.cancelGameSettingsBtn.Label = global::Mono.Unix.Catalog.GetString("Cancel");
			this.hbox14.Add(this.cancelGameSettingsBtn);
			global::Gtk.Box.BoxChild w24 = ((global::Gtk.Box.BoxChild)(this.hbox14[this.cancelGameSettingsBtn]));
			w24.Position = 1;
			w24.Expand = false;
			w24.Fill = false;
			// Container child hbox14.Gtk.Box+BoxChild
			this.startGameBtn = new global::Gtk.Button();
			this.startGameBtn.WidthRequest = 60;
			this.startGameBtn.HeightRequest = 35;
			this.startGameBtn.CanFocus = true;
			this.startGameBtn.Name = "startGameBtn";
			this.startGameBtn.UseUnderline = true;
			this.startGameBtn.Label = global::Mono.Unix.Catalog.GetString("Start");
			this.hbox14.Add(this.startGameBtn);
			global::Gtk.Box.BoxChild w25 = ((global::Gtk.Box.BoxChild)(this.hbox14[this.startGameBtn]));
			w25.Position = 2;
			w25.Expand = false;
			w25.Fill = false;
			this.vbox15.Add(this.hbox14);
			global::Gtk.Box.BoxChild w26 = ((global::Gtk.Box.BoxChild)(this.vbox15[this.hbox14]));
			w26.Position = 2;
			w26.Expand = false;
			w26.Fill = false;
			this.vbox10.Add(this.vbox15);
			global::Gtk.Box.BoxChild w27 = ((global::Gtk.Box.BoxChild)(this.vbox10[this.vbox15]));
			w27.Position = 2;
			w27.Expand = false;
			w27.Fill = false;
			this.Add(this.vbox10);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.DefaultWidth = 400;
			this.DefaultHeight = 300;
			this.Show();
			this.cancelGameSettingsBtn.Clicked += new global::System.EventHandler(this.OnCancelGameSettingsBtnClicked);
			this.startGameBtn.Clicked += new global::System.EventHandler(this.OnStartGameBtnClicked);
		}
	}
}
