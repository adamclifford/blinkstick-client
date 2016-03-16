
// This file has been generated by the GUI designer. Do not modify.
namespace BlinkStickClient
{
	public partial class OverviewSingleWidget
	{
		private global::Gtk.VBox vbox3;
		
		private global::Gtk.HBox hboxMiniMenu;
		
		private global::Gtk.Alignment alignment1;
		
		private global::Gtk.Button buttonRefresh;
		
		private global::Gtk.Button buttonConfigure;
		
		private global::BlinkStickClient.BlinkStickInfoWidget blinkstickinfowidget2;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget BlinkStickClient.OverviewSingleWidget
			global::Stetic.BinContainer.Attach (this);
			this.Name = "BlinkStickClient.OverviewSingleWidget";
			// Container child BlinkStickClient.OverviewSingleWidget.Gtk.Container+ContainerChild
			this.vbox3 = new global::Gtk.VBox ();
			this.vbox3.Name = "vbox3";
			this.vbox3.Spacing = 6;
			// Container child vbox3.Gtk.Box+BoxChild
			this.hboxMiniMenu = new global::Gtk.HBox ();
			this.hboxMiniMenu.Name = "hboxMiniMenu";
			this.hboxMiniMenu.Spacing = 6;
			this.hboxMiniMenu.BorderWidth = ((uint)(12));
			// Container child hboxMiniMenu.Gtk.Box+BoxChild
			this.alignment1 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.alignment1.Name = "alignment1";
			// Container child alignment1.Gtk.Container+ContainerChild
			this.buttonRefresh = new global::Gtk.Button ();
			this.buttonRefresh.CanFocus = true;
			this.buttonRefresh.Name = "buttonRefresh";
			this.buttonRefresh.UseUnderline = true;
			global::Gtk.Image w1 = new global::Gtk.Image ();
			w1.Pixbuf = global::Gdk.Pixbuf.LoadFromResource ("BlinkStickClient.Resources.icons.icon-dark-refresh.png");
			this.buttonRefresh.Image = w1;
			this.alignment1.Add (this.buttonRefresh);
			this.hboxMiniMenu.Add (this.alignment1);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hboxMiniMenu [this.alignment1]));
			w3.Position = 0;
			w3.Expand = false;
			w3.Fill = false;
			// Container child hboxMiniMenu.Gtk.Box+BoxChild
			this.buttonConfigure = new global::Gtk.Button ();
			this.buttonConfigure.CanFocus = true;
			this.buttonConfigure.Name = "buttonConfigure";
			this.buttonConfigure.UseUnderline = true;
			global::Gtk.Image w4 = new global::Gtk.Image ();
			w4.Pixbuf = global::Gdk.Pixbuf.LoadFromResource ("BlinkStickClient.Resources.icons.icon-dark-cog-small.png");
			this.buttonConfigure.Image = w4;
			this.hboxMiniMenu.Add (this.buttonConfigure);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hboxMiniMenu [this.buttonConfigure]));
			w5.Position = 1;
			w5.Expand = false;
			w5.Fill = false;
			this.vbox3.Add (this.hboxMiniMenu);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.hboxMiniMenu]));
			w6.Position = 0;
			w6.Expand = false;
			w6.Fill = false;
			// Container child vbox3.Gtk.Box+BoxChild
			this.blinkstickinfowidget2 = null;
			this.vbox3.Add (this.blinkstickinfowidget2);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.blinkstickinfowidget2]));
			w7.Position = 1;
			w7.Expand = false;
			w7.Fill = false;
			this.Add (this.vbox3);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Hide ();
			this.buttonRefresh.Clicked += new global::System.EventHandler (this.OnButtonRefreshClicked);
			this.buttonConfigure.Clicked += new global::System.EventHandler (this.OnButtonConfigureClicked);
		}
	}
}
