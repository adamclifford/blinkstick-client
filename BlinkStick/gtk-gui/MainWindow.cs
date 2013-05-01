
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.UIManager UIManager;
	private global::Gtk.Action newAction;
	private global::Gtk.Action editAction;
	private global::Gtk.Action deleteAction;
	private global::Gtk.RadioAction saveAction;
	private global::Gtk.Action copyAction;
	private global::Gtk.ToggleAction activeAction;
	private global::Gtk.Action FileAction;
	private global::Gtk.Action quitAction;
	private global::Gtk.Action BlinkStickAction;
	private global::Gtk.Action TestAction;
	private global::Gtk.Action ManageAction;
	private global::Gtk.Action HelpAction;
	private global::Gtk.Action SupportAction;
	private global::Gtk.Action AboutAction;
	private global::Gtk.Action HideAction;
	private global::Gtk.Action ReportABugAction;
	private global::Gtk.Action Action;
	private global::Gtk.Action OpenLogAction;
	private global::Gtk.VBox vbox2;
	private global::Gtk.MenuBar menubar2;
	private global::Gtk.VBox vbox3;
	private global::Gtk.Toolbar toolbar1;
	private global::Gtk.ScrolledWindow GtkScrolledWindow;
	private global::Gtk.TreeView treeviewEvents;
	private global::Gtk.Statusbar statusbar1;
	
	protected virtual void Build ()
	{
		global::Stetic.Gui.Initialize (this);
		// Widget MainWindow
		this.UIManager = new global::Gtk.UIManager ();
		global::Gtk.ActionGroup w1 = new global::Gtk.ActionGroup ("Default");
		this.newAction = new global::Gtk.Action ("newAction", global::Mono.Unix.Catalog.GetString ("_New"), null, "gtk-new");
		this.newAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("New");
		w1.Add (this.newAction, null);
		this.editAction = new global::Gtk.Action ("editAction", null, null, "gtk-edit");
		w1.Add (this.editAction, null);
		this.deleteAction = new global::Gtk.Action ("deleteAction", null, null, "gtk-delete");
		w1.Add (this.deleteAction, null);
		this.saveAction = new global::Gtk.RadioAction ("saveAction", null, null, "gtk-save", 0);
		this.saveAction.Group = new global::GLib.SList (global::System.IntPtr.Zero);
		w1.Add (this.saveAction, null);
		this.copyAction = new global::Gtk.Action ("copyAction", null, null, "gtk-copy");
		w1.Add (this.copyAction, null);
		this.activeAction = new global::Gtk.ToggleAction ("activeAction", global::Mono.Unix.Catalog.GetString ("_Active"), null, "gtk-yes");
		this.activeAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("_Active");
		w1.Add (this.activeAction, null);
		this.FileAction = new global::Gtk.Action ("FileAction", global::Mono.Unix.Catalog.GetString ("File"), null, null);
		this.FileAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("File");
		w1.Add (this.FileAction, null);
		this.quitAction = new global::Gtk.Action ("quitAction", global::Mono.Unix.Catalog.GetString ("Exit"), null, "gtk-quit");
		this.quitAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Exit");
		w1.Add (this.quitAction, null);
		this.BlinkStickAction = new global::Gtk.Action ("BlinkStickAction", global::Mono.Unix.Catalog.GetString ("BlinkStick"), null, null);
		this.BlinkStickAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Device");
		w1.Add (this.BlinkStickAction, null);
		this.TestAction = new global::Gtk.Action ("TestAction", global::Mono.Unix.Catalog.GetString ("Test..."), null, null);
		this.TestAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Test...");
		w1.Add (this.TestAction, null);
		this.ManageAction = new global::Gtk.Action ("ManageAction", global::Mono.Unix.Catalog.GetString ("Manage..."), null, null);
		this.ManageAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Manage...");
		w1.Add (this.ManageAction, null);
		this.HelpAction = new global::Gtk.Action ("HelpAction", global::Mono.Unix.Catalog.GetString ("Help"), null, null);
		this.HelpAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Help");
		w1.Add (this.HelpAction, null);
		this.SupportAction = new global::Gtk.Action ("SupportAction", global::Mono.Unix.Catalog.GetString ("Support"), null, null);
		this.SupportAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Support");
		w1.Add (this.SupportAction, null);
		this.AboutAction = new global::Gtk.Action ("AboutAction", global::Mono.Unix.Catalog.GetString ("About"), null, null);
		this.AboutAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("About");
		w1.Add (this.AboutAction, null);
		this.HideAction = new global::Gtk.Action ("HideAction", global::Mono.Unix.Catalog.GetString ("Hide"), null, null);
		this.HideAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Hide");
		w1.Add (this.HideAction, null);
		this.ReportABugAction = new global::Gtk.Action ("ReportABugAction", global::Mono.Unix.Catalog.GetString ("Report a Bug"), null, null);
		this.ReportABugAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Report a Bug");
		w1.Add (this.ReportABugAction, null);
		this.Action = new global::Gtk.Action ("Action", global::Mono.Unix.Catalog.GetString ("-"), null, null);
		this.Action.ShortLabel = global::Mono.Unix.Catalog.GetString ("-");
		w1.Add (this.Action, null);
		this.OpenLogAction = new global::Gtk.Action ("OpenLogAction", global::Mono.Unix.Catalog.GetString ("Open Log"), null, null);
		this.OpenLogAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Open Log");
		w1.Add (this.OpenLogAction, null);
		this.UIManager.InsertActionGroup (w1, 0);
		this.AddAccelGroup (this.UIManager.AccelGroup);
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString ("BlinkStick");
		this.WindowPosition = ((global::Gtk.WindowPosition)(1));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.vbox2 = new global::Gtk.VBox ();
		this.vbox2.Name = "vbox2";
		this.vbox2.Spacing = 6;
		// Container child vbox2.Gtk.Box+BoxChild
		this.UIManager.AddUiFromString (@"<ui><menubar name='menubar2'><menu name='FileAction' action='FileAction'><menuitem name='HideAction' action='HideAction'/><menuitem name='quitAction' action='quitAction'/></menu><menu name='BlinkStickAction' action='BlinkStickAction'><menuitem name='TestAction' action='TestAction'/><menuitem name='ManageAction' action='ManageAction'/></menu><menu name='HelpAction' action='HelpAction'><menuitem name='SupportAction' action='SupportAction'/><menuitem name='ReportABugAction' action='ReportABugAction'/><menuitem name='OpenLogAction' action='OpenLogAction'/><separator/><menuitem name='AboutAction' action='AboutAction'/></menu></menubar></ui>");
		this.menubar2 = ((global::Gtk.MenuBar)(this.UIManager.GetWidget ("/menubar2")));
		this.menubar2.Name = "menubar2";
		this.vbox2.Add (this.menubar2);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.menubar2]));
		w2.Position = 0;
		w2.Expand = false;
		w2.Fill = false;
		// Container child vbox2.Gtk.Box+BoxChild
		this.vbox3 = new global::Gtk.VBox ();
		this.vbox3.Name = "vbox3";
		this.vbox3.Spacing = 6;
		// Container child vbox3.Gtk.Box+BoxChild
		this.UIManager.AddUiFromString (@"<ui><toolbar name='toolbar1'><toolitem name='newAction' action='newAction'/><toolitem name='copyAction' action='copyAction'/><toolitem name='editAction' action='editAction'/><toolitem name='deleteAction' action='deleteAction'/><toolitem name='activeAction' action='activeAction'/></toolbar></ui>");
		this.toolbar1 = ((global::Gtk.Toolbar)(this.UIManager.GetWidget ("/toolbar1")));
		this.toolbar1.Name = "toolbar1";
		this.toolbar1.ShowArrow = false;
		this.toolbar1.ToolbarStyle = ((global::Gtk.ToolbarStyle)(2));
		this.toolbar1.IconSize = ((global::Gtk.IconSize)(2));
		this.vbox3.Add (this.toolbar1);
		global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.toolbar1]));
		w3.Position = 0;
		w3.Expand = false;
		w3.Fill = false;
		// Container child vbox3.Gtk.Box+BoxChild
		this.GtkScrolledWindow = new global::Gtk.ScrolledWindow ();
		this.GtkScrolledWindow.Name = "GtkScrolledWindow";
		this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
		// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
		this.treeviewEvents = new global::Gtk.TreeView ();
		this.treeviewEvents.CanFocus = true;
		this.treeviewEvents.Name = "treeviewEvents";
		this.GtkScrolledWindow.Add (this.treeviewEvents);
		this.vbox3.Add (this.GtkScrolledWindow);
		global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.GtkScrolledWindow]));
		w5.Position = 1;
		this.vbox2.Add (this.vbox3);
		global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.vbox3]));
		w6.Position = 1;
		// Container child vbox2.Gtk.Box+BoxChild
		this.statusbar1 = new global::Gtk.Statusbar ();
		this.statusbar1.Name = "statusbar1";
		this.statusbar1.Spacing = 6;
		this.vbox2.Add (this.statusbar1);
		global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.statusbar1]));
		w7.Position = 2;
		w7.Expand = false;
		w7.Fill = false;
		this.Add (this.vbox2);
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.DefaultWidth = 776;
		this.DefaultHeight = 624;
		this.Show ();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
		this.newAction.Activated += new global::System.EventHandler (this.OnNewActionActivated);
		this.editAction.Activated += new global::System.EventHandler (this.OnEditActionActivated);
		this.deleteAction.Activated += new global::System.EventHandler (this.OnDeleteActionActivated);
		this.copyAction.Activated += new global::System.EventHandler (this.OnCopyActionActivated);
		this.activeAction.Toggled += new global::System.EventHandler (this.OnActiveActionToggled);
		this.quitAction.Activated += new global::System.EventHandler (this.OnQuitActionActivated);
		this.TestAction.Activated += new global::System.EventHandler (this.OnTestActionActivated);
		this.ManageAction.Activated += new global::System.EventHandler (this.OnManageActionActivated);
		this.SupportAction.Activated += new global::System.EventHandler (this.OnSupportActionActivated);
		this.AboutAction.Activated += new global::System.EventHandler (this.OnAboutActionActivated);
		this.HideAction.Activated += new global::System.EventHandler (this.OnHideActionActivated);
		this.ReportABugAction.Activated += new global::System.EventHandler (this.OnReportABugActionActivated);
		this.OpenLogAction.Activated += new global::System.EventHandler (this.OnOpenLogActionActivated);
		this.treeviewEvents.CursorChanged += new global::System.EventHandler (this.OnTreeviewEventsCursorChanged);
		this.treeviewEvents.RowActivated += new global::Gtk.RowActivatedHandler (this.OnTreeviewEventsRowActivated);
	}
}
