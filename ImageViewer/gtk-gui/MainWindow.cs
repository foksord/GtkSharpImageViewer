
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.UIManager UIManager;

	private global::Gtk.Action FileAction;

	private global::Gtk.Action ChoseImageAction;

	private global::Gtk.Action OpenAction;

	private global::Gtk.Action AboutAction;

	private global::Gtk.Action ExitAction;

	private global::Gtk.Action FileAction1;

	private global::Gtk.Action OpenAction1;

	private global::Gtk.Action AboutAction1;

	private global::Gtk.Action ExitAction1;

	private global::Gtk.VBox vbox3;

	private global::Gtk.MenuBar menubar4;

	private global::Gtk.Image displayImage;

	protected virtual void Build()
	{
		global::Stetic.Gui.Initialize(this);
		// Widget MainWindow
		this.UIManager = new global::Gtk.UIManager();
		global::Gtk.ActionGroup w1 = new global::Gtk.ActionGroup("Default");
		this.FileAction = new global::Gtk.Action("FileAction", global::Mono.Unix.Catalog.GetString("File"), null, null);
		this.FileAction.ShortLabel = global::Mono.Unix.Catalog.GetString("File");
		w1.Add(this.FileAction, null);
		this.ChoseImageAction = new global::Gtk.Action("ChoseImageAction", global::Mono.Unix.Catalog.GetString("Chose Image"), null, null);
		this.ChoseImageAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Chose Image");
		w1.Add(this.ChoseImageAction, null);
		this.OpenAction = new global::Gtk.Action("OpenAction", global::Mono.Unix.Catalog.GetString("Open"), null, null);
		this.OpenAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Open");
		w1.Add(this.OpenAction, null);
		this.AboutAction = new global::Gtk.Action("AboutAction", global::Mono.Unix.Catalog.GetString("About"), null, null);
		this.AboutAction.ShortLabel = global::Mono.Unix.Catalog.GetString("About");
		w1.Add(this.AboutAction, null);
		this.ExitAction = new global::Gtk.Action("ExitAction", global::Mono.Unix.Catalog.GetString("Exit"), null, null);
		this.ExitAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Exit");
		w1.Add(this.ExitAction, null);
		this.FileAction1 = new global::Gtk.Action("FileAction1", global::Mono.Unix.Catalog.GetString("File"), null, null);
		this.FileAction1.ShortLabel = global::Mono.Unix.Catalog.GetString("File");
		w1.Add(this.FileAction1, null);
		this.OpenAction1 = new global::Gtk.Action("OpenAction1", global::Mono.Unix.Catalog.GetString("Open"), null, null);
		this.OpenAction1.ShortLabel = global::Mono.Unix.Catalog.GetString("Open");
		w1.Add(this.OpenAction1, null);
		this.AboutAction1 = new global::Gtk.Action("AboutAction1", global::Mono.Unix.Catalog.GetString("About"), null, null);
		this.AboutAction1.ShortLabel = global::Mono.Unix.Catalog.GetString("About");
		w1.Add(this.AboutAction1, null);
		this.ExitAction1 = new global::Gtk.Action("ExitAction1", global::Mono.Unix.Catalog.GetString("Exit"), null, null);
		this.ExitAction1.ShortLabel = global::Mono.Unix.Catalog.GetString("Exit");
		w1.Add(this.ExitAction1, null);
		this.UIManager.InsertActionGroup(w1, 0);
		this.AddAccelGroup(this.UIManager.AccelGroup);
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString("MainWindow");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.vbox3 = new global::Gtk.VBox();
		this.vbox3.Name = "vbox3";
		this.vbox3.Spacing = 6;
		// Container child vbox3.Gtk.Box+BoxChild
		this.UIManager.AddUiFromString("<ui><menubar name=\'menubar4\'><menu name=\'FileAction1\' action=\'FileAction1\'><menui" +
				"tem name=\'OpenAction1\' action=\'OpenAction1\'/><menuitem name=\'AboutAction1\' actio" +
				"n=\'AboutAction1\'/><menuitem name=\'ExitAction1\' action=\'ExitAction1\'/></menu></me" +
				"nubar></ui>");
		this.menubar4 = ((global::Gtk.MenuBar)(this.UIManager.GetWidget("/menubar4")));
		this.menubar4.Name = "menubar4";
		this.vbox3.Add(this.menubar4);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.menubar4]));
		w2.Position = 0;
		w2.Expand = false;
		w2.Fill = false;
		// Container child vbox3.Gtk.Box+BoxChild
		this.displayImage = new global::Gtk.Image();
		this.displayImage.Name = "displayImage";
		this.vbox3.Add(this.displayImage);
		global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.displayImage]));
		w3.Position = 1;
		w3.Expand = false;
		w3.Fill = false;
		this.Add(this.vbox3);
		if ((this.Child != null))
		{
			this.Child.ShowAll();
		}
		this.DefaultWidth = 400;
		this.DefaultHeight = 300;
		this.Show();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler(this.OnDeleteEvent);
		this.OpenAction.Activated += new global::System.EventHandler(this.OnOpen);
		this.AboutAction.Activated += new global::System.EventHandler(this.OnAbout);
		this.ExitAction.Activated += new global::System.EventHandler(this.OnExit);
		this.OpenAction1.Activated += new global::System.EventHandler(this.OnOpen);
		this.AboutAction1.Activated += new global::System.EventHandler(this.OnAbout);
		this.ExitAction1.Activated += new global::System.EventHandler(this.OnExit);
	}
}